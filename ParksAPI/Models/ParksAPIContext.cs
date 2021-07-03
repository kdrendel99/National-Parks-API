using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
  public class ParksAPIContext : DbContext
  {
    public ParksAPIContext(DbContextOptions<ParksAPIContext> options) : base(options)
    {
    }
    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Acadia", State = "Maine", MainAttraction = "Tallest mountain on the Atlantic coast of the USA."},
          new Park { ParkId = 2, Name = "American Samoa", State = "American Samoa", MainAttraction = "Rainforests, volcanic mountains, white beaches."},
          new Park { ParkId = 3, Name = "Arches", State = "Utah", MainAttraction = "Delicate Arch, Landscape Arch, and Double Arch."},
          new Park { ParkId = 4, Name = "Badlands", State = "South Dakota", MainAttraction = "Buttes, fossils, the White River."},
          new Park { ParkId = 5, Name = "Big Bend", State = "Texas", MainAttraction = "Chisos mountains."},
          new Park { ParkId = 6, Name = "Biscayne", State = "Florida", MainAttraction = "Coral reefs."},
          new Park { ParkId = 7, Name = "Black Canyon of the Gunnison", State = "Colorado", MainAttraction = "Rock climbing."},
          new Park { ParkId = 8, Name = "Bryce Canyon", State = "Utah", MainAttraction = "Sandstone hoodoos."},
          new Park { ParkId = 9, Name = "Canyonlands", State = "Utah", MainAttraction = "Colorado River, Green River, and their tributaries."},
          new Park { ParkId = 10, Name = "Capitol Reef", State = "Utah", MainAttraction = "Waterpocket Fold monocline."},
          new Park { ParkId = 11, Name = "Carlsbad Caverns", State = "New Mexico", MainAttraction = "The Big Room cave."},
          new Park { ParkId = 12, Name = "Channel Islands", State = "California", MainAttraction = "the unique Mediterranean ecosystem."},
          new Park { ParkId = 13, Name = "Congaree", State = "South Carolina", MainAttraction = "Contains the most old-growth floodplain forest left in North America."},
          new Park { ParkId = 14, Name = "Crater Lake", State = "Oregon", MainAttraction = "Deepest lake in the USA."},
          new Park { ParkId = 15, Name = "Cuyahoga Valley", State = "Ohio", MainAttraction = "Waterfalls, plus historic homes, bridges, and structures."},
          new Park { ParkId = 16, Name = "Death Valley", State = "California, Nevada", MainAttraction = "Hottest, lowest, and driest place in the USA."},
          new Park { ParkId = 17, Name = "Denali", State = "Alaska", MainAttraction = "Denali, Wonder Lake, Alaskan Range, wildlife."},
          new Park { ParkId = 18, Name = "Dry Tortugas", State = "Florida", MainAttraction = "Fort Jefferson, the largest masonry structure in the Western Hemisphere."},
          new Park { ParkId = 19, Name = "Everglades", State = "Florida", MainAttraction = "Largest tropical wilderness in the USA."},
          new Park { ParkId = 20, Name = "Gates of the Artic", State = "Alaska", MainAttraction = "Alaskan wilderness."},
          new Park { ParkId = 21, Name = "Gateway Arch", State = "Missouri", MainAttraction = "The Gateway Arch: a 630 foot high arch built to commemorate the Lewis and Clark expedition."},
          new Park { ParkId = 22, Name = "Glacier", State = "Montana", MainAttraction = "26 glaciers and 130 named lakes, the Rocky Mountains."},
          new Park { ParkId = 23, Name = "Glacier Bay", State = "Alaska", MainAttraction = "Fjords, tidewater glaciers, a temperate rainforest."},
          new Park { ParkId = 24, Name = "Grand Canyon", State = "Arizona", MainAttraction = "The Grand Canyon; up to a mile deep and carved by the mighty Colorado River."},
          new Park { ParkId = 25, Name = "Grand Teton", State = "Wyoming", MainAttraction = "Jackson Hole."},
          new Park { ParkId = 26, Name = "Great Basin", State = "Nevada", MainAttraction = "Wheeler Peak, limestone caves."},
          new Park { ParkId = 27, Name = "Great Sand Dunes", State = "Colorado", MainAttraction = "Tallest sand dunes in North America."},
          new Park { ParkId = 28, Name = "Great Smoky Mountains", State = "North Carolina, Tennessee", MainAttraction = "Over 800 miles of hiking trails."},
          new Park { ParkId = 29, Name = "Guadalupe Mountains", State = "Texas", MainAttraction = "Guadalupe Peak, the highest point in Texas."},
          new Park { ParkId = 30, Name = "Haleakalā", State = "Hawaii", MainAttraction = "Haleakalā volcano."},
          new Park { ParkId = 31, Name = "Hawaiʻi Volcanoes", State = "Hawaii", MainAttraction = "Kīlauea and Mauna Loa volcanoes, two of the world's most active geological features."},
          new Park { ParkId = 32, Name = "Hot Springs", State = "Arkansas", MainAttraction = "Natural hot springs flowing out of the Ouachita Mountains."},
          new Park { ParkId = 33, Name = "Indiana Dunes", State = "Indiana", MainAttraction = "Sandy beaches and tall dunes."},
          new Park { ParkId = 34, Name = "Isle Royale", State = "Michigan", MainAttraction = "Shipwrecks, waterways, hiking trails."},
          new Park { ParkId = 35, Name = "Joshua Tree", State = "California", MainAttraction = "Joshua trees, sand dunes, rugged mountains."},
          new Park { ParkId = 36, Name = "Katmai", State = "Alaska", MainAttraction = "The Valley of Ten Thousand Smokes, an ash flow from a nearby volcanic eruption. Wildlife, sightseeing, backpacking."},
          new Park { ParkId = 37, Name = "Kenai Fjords", State = "Alaska", MainAttraction = "38 glaciers and fjords, Exit Glacier."},
          new Park { ParkId = 38, Name = "Kings Canyon", State = "California", MainAttraction = "General Grant Tree, the world's second largest measured tree."},
          new Park { ParkId = 39, Name = "Kobuk Valley", State = "Alaska", MainAttraction = "Kobuk River, Great Kobuk and Little Kobuk sand dunes."},
          new Park { ParkId = 40, Name = "Lake Clark", State = "Alaska", MainAttraction = "Four active volcanoes, rivers, glaciers, waterfalls."},
          new Park { ParkId = 41, Name = "Lassen Volcanic", State = "California", MainAttraction = "Lassen Peak, the largest lava dome volcano in the world."},
          new Park { ParkId = 42, Name = "Mammoth Cave", State = "Kentucky", MainAttraction = "World's longest known cave system (400+ miles)."},
          new Park { ParkId = 43, Name = "Mesa Verde", State = "Colorado", MainAttraction = "Over 4,000 archaeological sites of the Ancestral Puebloan people, including Cliff Palace and Balcony House."},
          new Park { ParkId = 44, Name = "Mount Rainier", State = "Washington", MainAttraction = "Mount Rainier, the most prominent peak in the Cascades. Glaciers, climbing, backpacking."},
          new Park { ParkId = 45, Name = "New River Gorge", State = "West Virginia", MainAttraction = "The deepest river gorge east of the Mississippi River. Whitewater rafting and sightseeing."},
          new Park { ParkId = 46, Name = "North Cascades", State = "Washington", MainAttraction = "Hiking, climbing, backpacking. The glaciated mountains exhibit complex geologic history."},
          new Park { ParkId = 47, Name = "Olympic", State = "Washington", MainAttraction = "Mount Olympus."},
          new Park { ParkId = 48, Name = "Petrified Forest", State = "Arizona", MainAttraction = "225-million-year-old petrified wood. Painted Desert, dinosaur fossils, and Native American sites."},
          new Park { ParkId = 49, Name = "Pinnacles", State = "California", MainAttraction = "Massive black and gold monoliths make it a popular destination for rock climbers."},
          new Park { ParkId = 50, Name = "Redwood", State = "California", MainAttraction = "The coastal redwoods are the tallest trees on earth."},
          new Park { ParkId = 51, Name = "Rocky Mountain", State = "Colorado", MainAttraction = "Wildlife, hiking trails."},
          new Park { ParkId = 52, Name = "Saguaro", State = "Arizona", MainAttraction = "Diverse wildlife, cactus, wildflowers."},
          new Park { ParkId = 53, Name = "Sequoia", State = "California", MainAttraction = "The largest measured tree in the park: General Sherman. Caves, the tallest mountain in the contiguous USA, Moro Rock."},
          new Park { ParkId = 54, Name = "Shenandoah", State = "Virginia", MainAttraction = "Part of the Skyline Drive and Appalachian Trail. 500+ miles of hiking trails."},
          new Park { ParkId = 55, Name = "Theodore Roosevelt", State = "North Dakota", MainAttraction = "Roosevelt's historic cabin, bison, backpacking, hiking."},
          new Park { ParkId = 56, Name = "Virgin Islands", State = "U.S Virgin Islands", MainAttraction = "Beaches, mangrove forests, ruins of sugar plantations from Columbus's time."},
          new Park { ParkId = 57, Name = "Voyageurs", State = "Minnesota", MainAttraction = "Canoeing, kayaking, fishing."},
          new Park { ParkId = 58, Name = "White Sands", State = "New Mexico", MainAttraction = "The worlds largest gypsum dunefield."},
          new Park { ParkId = 59, Name = "Wind Cave", State = "South Dakota", MainAttraction = "Calcite fin formations called boxwork, a unique formation rarely found elsewhere."},
          new Park { ParkId = 60, Name = "Wrangell–St. Elias", State = "Alaska", MainAttraction = "Largest national park, and includes many of the continent's tallest mountains/volcanoes."},
          new Park { ParkId = 61, Name = "Yellowstone", State = "Wyoming, Montana, Idaho", MainAttraction = "Old Faithful geyser."},
          new Park { ParkId = 62, Name = "Yosemite", State = "California", MainAttraction = "Half Dome, El Capitan. Popular for climbers."},
          new Park { ParkId = 63, Name = "Zion", State = "Utah", MainAttraction = "Sandstone formations, and the Virgin River"}
        );
    }
  }
}