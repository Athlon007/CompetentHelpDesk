using Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Logic
{
    public class IncidentFilteringService
    {
        // Individual part (Incident Filtering) by Rodrigo Bange, 684006, IT2A

        /// <summary>
        /// Filters a pre-loaded list of incidents by the given filter.
        /// </summary>
        /// <param name="incidents">List of incidents to filter.</param>
        /// <param name="filter">String of filter keywords.</param>
        /// <returns>A filtered list of Incident objects.</returns>
        public List<Incident> FilterIncidents(List<Incident> incidents, string filter)
        {
            // Split the filter into multiple keywords
            string[] keywords = GetKeywords(filter);

            // Create a new filtered list
            List<Incident> filteredIncidents = new List<Incident>();

            // Check each incident's main information if it contains the requested value
            foreach (Incident incident in incidents)
            {
                foreach (string keyword in keywords)
                {
                    // Check if the Subject or IncidentType contain a word that is a perfect match with the keyword
                    if (Regex.IsMatch(incident.Subject, $"\\b{keyword}\\b", RegexOptions.IgnoreCase) ||
                        Regex.IsMatch(incident.IncidentType.ToString(), $"\\b{keyword}\\b", RegexOptions.IgnoreCase))
                    {
                        // Add the incident to the filtered list and proceed with next incident. 
                        filteredIncidents.Add(incident);
                        break;
                    }
                }
            }

            return filteredIncidents; 
        }

        /// <summary>
        /// Splits up the filter into multiple strings to get all the keywords.
        /// </summary>
        /// <param name="filter">String to split.</param>
        /// <returns>Returns an array of keywords.</returns>
        string[] GetKeywords(string filter)
        {
            // Get all the keywords by removing the empty spaces and commas from filter
            return filter.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
