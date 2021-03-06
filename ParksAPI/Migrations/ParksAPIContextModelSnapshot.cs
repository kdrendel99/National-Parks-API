// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksAPI.Models;

namespace ParksAPI.Migrations
{
    [DbContext(typeof(ParksAPIContext))]
    partial class ParksAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksAPI.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MainAttraction")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            MainAttraction = "Tallest mountain on the Atlantic coast of the USA.",
                            Name = "Acadia",
                            State = "Maine"
                        },
                        new
                        {
                            ParkId = 2,
                            MainAttraction = "Rainforests, volcanic mountains, white beaches.",
                            Name = "American Samoa",
                            State = "American Samoa"
                        },
                        new
                        {
                            ParkId = 3,
                            MainAttraction = "Delicate Arch, Landscape Arch, and Double Arch.",
                            Name = "Arches",
                            State = "Utah"
                        },
                        new
                        {
                            ParkId = 4,
                            MainAttraction = "Buttes, fossils, the White River.",
                            Name = "Badlands",
                            State = "South Dakota"
                        },
                        new
                        {
                            ParkId = 5,
                            MainAttraction = "Chisos mountains.",
                            Name = "Big Bend",
                            State = "Texas"
                        },
                        new
                        {
                            ParkId = 6,
                            MainAttraction = "Coral reefs.",
                            Name = "Biscayne",
                            State = "Florida"
                        },
                        new
                        {
                            ParkId = 7,
                            MainAttraction = "Rock climbing.",
                            Name = "Black Canyon of the Gunnison",
                            State = "Colorado"
                        },
                        new
                        {
                            ParkId = 8,
                            MainAttraction = "Sandstone hoodoos.",
                            Name = "Bryce Canyon",
                            State = "Utah"
                        },
                        new
                        {
                            ParkId = 9,
                            MainAttraction = "Colorado River, Green River, and their tributaries.",
                            Name = "Canyonlands",
                            State = "Utah"
                        },
                        new
                        {
                            ParkId = 10,
                            MainAttraction = "Waterpocket Fold monocline.",
                            Name = "Capitol Reef",
                            State = "Utah"
                        },
                        new
                        {
                            ParkId = 11,
                            MainAttraction = "The Big Room cave.",
                            Name = "Carlsbad Caverns",
                            State = "New Mexico"
                        },
                        new
                        {
                            ParkId = 12,
                            MainAttraction = "the unique Mediterranean ecosystem.",
                            Name = "Channel Islands",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 13,
                            MainAttraction = "Contains the most old-growth floodplain forest left in North America.",
                            Name = "Congaree",
                            State = "South Carolina"
                        },
                        new
                        {
                            ParkId = 14,
                            MainAttraction = "Deepest lake in the USA.",
                            Name = "Crater Lake",
                            State = "Oregon"
                        },
                        new
                        {
                            ParkId = 15,
                            MainAttraction = "Waterfalls, plus historic homes, bridges, and structures.",
                            Name = "Cuyahoga Valley",
                            State = "Ohio"
                        },
                        new
                        {
                            ParkId = 16,
                            MainAttraction = "Hottest, lowest, and driest place in the USA.",
                            Name = "Death Valley",
                            State = "California, Nevada"
                        },
                        new
                        {
                            ParkId = 17,
                            MainAttraction = "Denali, Wonder Lake, Alaskan Range, wildlife.",
                            Name = "Denali",
                            State = "Alaska"
                        },
                        new
                        {
                            ParkId = 18,
                            MainAttraction = "Fort Jefferson, the largest masonry structure in the Western Hemisphere.",
                            Name = "Dry Tortugas",
                            State = "Florida"
                        },
                        new
                        {
                            ParkId = 19,
                            MainAttraction = "Largest tropical wilderness in the USA.",
                            Name = "Everglades",
                            State = "Florida"
                        },
                        new
                        {
                            ParkId = 20,
                            MainAttraction = "Alaskan wilderness.",
                            Name = "Gates of the Artic",
                            State = "Alaska"
                        },
                        new
                        {
                            ParkId = 21,
                            MainAttraction = "The Gateway Arch: a 630 foot high arch built to commemorate the Lewis and Clark expedition.",
                            Name = "Gateway Arch",
                            State = "Missouri"
                        },
                        new
                        {
                            ParkId = 22,
                            MainAttraction = "26 glaciers and 130 named lakes, the Rocky Mountains.",
                            Name = "Glacier",
                            State = "Montana"
                        },
                        new
                        {
                            ParkId = 23,
                            MainAttraction = "Fjords, tidewater glaciers, a temperate rainforest.",
                            Name = "Glacier Bay",
                            State = "Alaska"
                        },
                        new
                        {
                            ParkId = 24,
                            MainAttraction = "The Grand Canyon; up to a mile deep and carved by the mighty Colorado River.",
                            Name = "Grand Canyon",
                            State = "Arizona"
                        },
                        new
                        {
                            ParkId = 25,
                            MainAttraction = "Jackson Hole.",
                            Name = "Grand Teton",
                            State = "Wyoming"
                        },
                        new
                        {
                            ParkId = 26,
                            MainAttraction = "Wheeler Peak, limestone caves.",
                            Name = "Great Basin",
                            State = "Nevada"
                        },
                        new
                        {
                            ParkId = 27,
                            MainAttraction = "Tallest sand dunes in North America.",
                            Name = "Great Sand Dunes",
                            State = "Colorado"
                        },
                        new
                        {
                            ParkId = 28,
                            MainAttraction = "Over 800 miles of hiking trails.",
                            Name = "Great Smoky Mountains",
                            State = "North Carolina, Tennessee"
                        },
                        new
                        {
                            ParkId = 29,
                            MainAttraction = "Guadalupe Peak, the highest point in Texas.",
                            Name = "Guadalupe Mountains",
                            State = "Texas"
                        },
                        new
                        {
                            ParkId = 30,
                            MainAttraction = "Haleakalā volcano.",
                            Name = "Haleakalā",
                            State = "Hawaii"
                        },
                        new
                        {
                            ParkId = 31,
                            MainAttraction = "Kīlauea and Mauna Loa volcanoes, two of the world's most active geological features.",
                            Name = "Hawaiʻi Volcanoes",
                            State = "Hawaii"
                        },
                        new
                        {
                            ParkId = 32,
                            MainAttraction = "Natural hot springs flowing out of the Ouachita Mountains.",
                            Name = "Hot Springs",
                            State = "Arkansas"
                        },
                        new
                        {
                            ParkId = 33,
                            MainAttraction = "Sandy beaches and tall dunes.",
                            Name = "Indiana Dunes",
                            State = "Indiana"
                        },
                        new
                        {
                            ParkId = 34,
                            MainAttraction = "Shipwrecks, waterways, hiking trails.",
                            Name = "Isle Royale",
                            State = "Michigan"
                        },
                        new
                        {
                            ParkId = 35,
                            MainAttraction = "Joshua trees, sand dunes, rugged mountains.",
                            Name = "Joshua Tree",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 36,
                            MainAttraction = "The Valley of Ten Thousand Smokes, an ash flow from a nearby volcanic eruption. Wildlife, sightseeing, backpacking.",
                            Name = "Katmai",
                            State = "Alaska"
                        },
                        new
                        {
                            ParkId = 37,
                            MainAttraction = "38 glaciers and fjords, Exit Glacier.",
                            Name = "Kenai Fjords",
                            State = "Alaska"
                        },
                        new
                        {
                            ParkId = 38,
                            MainAttraction = "General Grant Tree, the world's second largest measured tree.",
                            Name = "Kings Canyon",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 39,
                            MainAttraction = "Kobuk River, Great Kobuk and Little Kobuk sand dunes.",
                            Name = "Kobuk Valley",
                            State = "Alaska"
                        },
                        new
                        {
                            ParkId = 40,
                            MainAttraction = "Four active volcanoes, rivers, glaciers, waterfalls.",
                            Name = "Lake Clark",
                            State = "Alaska"
                        },
                        new
                        {
                            ParkId = 41,
                            MainAttraction = "Lassen Peak, the largest lava dome volcano in the world.",
                            Name = "Lassen Volcanic",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 42,
                            MainAttraction = "World's longest known cave system (400+ miles).",
                            Name = "Mammoth Cave",
                            State = "Kentucky"
                        },
                        new
                        {
                            ParkId = 43,
                            MainAttraction = "Over 4,000 archaeological sites of the Ancestral Puebloan people, including Cliff Palace and Balcony House.",
                            Name = "Mesa Verde",
                            State = "Colorado"
                        },
                        new
                        {
                            ParkId = 44,
                            MainAttraction = "Mount Rainier, the most prominent peak in the Cascades. Glaciers, climbing, backpacking.",
                            Name = "Mount Rainier",
                            State = "Washington"
                        },
                        new
                        {
                            ParkId = 45,
                            MainAttraction = "The deepest river gorge east of the Mississippi River. Whitewater rafting and sightseeing.",
                            Name = "New River Gorge",
                            State = "West Virginia"
                        },
                        new
                        {
                            ParkId = 46,
                            MainAttraction = "Hiking, climbing, backpacking. The glaciated mountains exhibit complex geologic history.",
                            Name = "North Cascades",
                            State = "Washington"
                        },
                        new
                        {
                            ParkId = 47,
                            MainAttraction = "Mount Olympus.",
                            Name = "Olympic",
                            State = "Washington"
                        },
                        new
                        {
                            ParkId = 48,
                            MainAttraction = "225-million-year-old petrified wood. Painted Desert, dinosaur fossils, and Native American sites.",
                            Name = "Petrified Forest",
                            State = "Arizona"
                        },
                        new
                        {
                            ParkId = 49,
                            MainAttraction = "Massive black and gold monoliths make it a popular destination for rock climbers.",
                            Name = "Pinnacles",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 50,
                            MainAttraction = "The coastal redwoods are the tallest trees on earth.",
                            Name = "Redwood",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 51,
                            MainAttraction = "Wildlife, hiking trails.",
                            Name = "Rocky Mountain",
                            State = "Colorado"
                        },
                        new
                        {
                            ParkId = 52,
                            MainAttraction = "Diverse wildlife, cactus, wildflowers.",
                            Name = "Saguaro",
                            State = "Arizona"
                        },
                        new
                        {
                            ParkId = 53,
                            MainAttraction = "The largest measured tree in the park: General Sherman. Caves, the tallest mountain in the contiguous USA, Moro Rock.",
                            Name = "Sequoia",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 54,
                            MainAttraction = "Part of the Skyline Drive and Appalachian Trail. 500+ miles of hiking trails.",
                            Name = "Shenandoah",
                            State = "Virginia"
                        },
                        new
                        {
                            ParkId = 55,
                            MainAttraction = "Roosevelt's historic cabin, bison, backpacking, hiking.",
                            Name = "Theodore Roosevelt",
                            State = "North Dakota"
                        },
                        new
                        {
                            ParkId = 56,
                            MainAttraction = "Beaches, mangrove forests, ruins of sugar plantations from Columbus's time.",
                            Name = "Virgin Islands",
                            State = "U.S Virgin Islands"
                        },
                        new
                        {
                            ParkId = 57,
                            MainAttraction = "Canoeing, kayaking, fishing.",
                            Name = "Voyageurs",
                            State = "Minnesota"
                        },
                        new
                        {
                            ParkId = 58,
                            MainAttraction = "The worlds largest gypsum dunefield.",
                            Name = "White Sands",
                            State = "New Mexico"
                        },
                        new
                        {
                            ParkId = 59,
                            MainAttraction = "Calcite fin formations called boxwork, a unique formation rarely found elsewhere.",
                            Name = "Wind Cave",
                            State = "South Dakota"
                        },
                        new
                        {
                            ParkId = 60,
                            MainAttraction = "Largest national park, and includes many of the continent's tallest mountains/volcanoes.",
                            Name = "Wrangell–St. Elias",
                            State = "Alaska"
                        },
                        new
                        {
                            ParkId = 61,
                            MainAttraction = "Old Faithful geyser.",
                            Name = "Yellowstone",
                            State = "Wyoming, Montana, Idaho"
                        },
                        new
                        {
                            ParkId = 62,
                            MainAttraction = "Half Dome, El Capitan. Popular for climbers.",
                            Name = "Yosemite",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 63,
                            MainAttraction = "Sandstone formations, and the Virgin River",
                            Name = "Zion",
                            State = "Utah"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
