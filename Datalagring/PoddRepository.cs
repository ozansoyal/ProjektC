﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;

namespace Datalagring
{
    public class PoddRepository
    {
        private AppData appData = new AppData { Podcasts = new List<Podcast>(), Categories = new List<Category>() };
        private readonly string xmlFilnamn = "appdata.xml";

        public void AddPodcast(Podcast podd)
        {
            foreach (Podcast p in appData.Podcasts)
            {
                if (p.Title == podd.Title)
                {
                    throw new Exception("Podcast existerar redan.");
                }
            }
            appData.Podcasts.Add(podd);
            SaveToFile(appData);
        }

        public List<Podcast> GetPodcastList()
        {
            return appData.Podcasts;
        }

        public void SaveToFile(AppData data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AppData));
            using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Create))
            {
                serializer.Serialize(fs, data);
            }
        }

        public AppData ReadFromFile()
        {
            if (File.Exists(xmlFilnamn))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppData));
                    using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Open))
                    {
                        appData = (AppData)serializer.Deserialize(fs);
                    }
                    if (appData == null || (appData.Podcasts.Count == 0 && appData.Categories.Count == 0))
                    {
                        Console.WriteLine("Deserialization resulted in an empty AppData.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                    using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Create)) ;
                }
            }
            else
            {
                using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Create)) ;
            }
            return appData;
        }

        public async Task RemovePodcastAsync(Podcast podd)
        {
            await Task.Run(() => appData.Podcasts.Remove(podd));
            await SaveToFileAsync(appData);
        }

        public async Task SaveToFileAsync(AppData data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AppData));
            using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Create))
            {
                await Task.Run(() => serializer.Serialize(fs, data));
            }
        }

        public async Task<AppData> ReadFromFileAsync()
        {
            if (File.Exists(xmlFilnamn))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppData));
                    using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Open))
                    {
                        appData = await Task.Run(() => (AppData)serializer.Deserialize(fs));
                    }
                    if (appData == null || (appData.Podcasts.Count == 0 && appData.Categories.Count == 0))
                    {
                        Console.WriteLine("Deserialization resulted in an empty AppData.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }
            }
            else
            {
                using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Create)) ;
            }
            return appData;
        }

        public void UpdatePodcast(Podcast updatedPodcast)
        {
            var podcasts = ReadFromFile().Podcasts;
            var existingPodcast = podcasts.FirstOrDefault(p => p.Title == updatedPodcast.Title);
            if (existingPodcast != null)
            {
                existingPodcast.Name = updatedPodcast.Name;
                existingPodcast.Category = updatedPodcast.Category;
                SaveToFile(appData);
            }
            else
            {
                Console.WriteLine("Podcast not found for update.");
            }
        }

        public void AddCategory(Category category)
        {
            foreach (Category c in appData.Categories)
            {
                if (c.Name == category.Name)
                {
                    throw new Exception("Kategori existerar redan.");
                }
            }
            appData.Categories.Add(category);
            SaveToFile(appData);
        }

        public void RemoveCategory(Category category)
        {
            var appData = ReadFromFile();

            var categoryToRemove = appData.Categories.FirstOrDefault(c => c.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase));

            if (categoryToRemove != null)
            {
                appData.Categories.Remove(categoryToRemove);

                if (appData.Podcasts != null)
                {
                    var podcastsToRemove = appData.Podcasts
                        .Where(p => p.Category != null && p.Category.Equals(categoryToRemove.Name, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    foreach (var podcast in podcastsToRemove)
                    {
                        podcast.Category = "";
                    }
                }

                SaveToFile(appData);
            }
            else
            {
                throw new Exception("Kategori hittades ej.");
            }
        }


        public async Task RemovePodcastByTitleAsync(string podcastTitle)
        {
            var podcastToRemove = appData.Podcasts.FirstOrDefault(p => p.Title == podcastTitle);
            if (podcastToRemove != null)
            {
                await Task.Run(() => appData.Podcasts.Remove(podcastToRemove));
                await SaveToFileAsync(appData);
                Console.WriteLine("Borttagning av podcast lyckades.");
            }
            else
            {
                Console.WriteLine("Podcast finns ej i listan.");
            }
        }
        public async Task RemovePodcastByNameAsync(string podcastName)
        {
            var podcastToRemove = appData.Podcasts.FirstOrDefault(p => p.Name == podcastName);
            if (podcastToRemove != null)
            {
                await Task.Run(() => appData.Podcasts.Remove(podcastToRemove));
                await SaveToFileAsync(appData);
                Console.WriteLine("Borttagning av podcast lyckades");
            }
            else
            {
                Console.WriteLine("Podcast finns ej i listan.");
            }
        }
    }
}
