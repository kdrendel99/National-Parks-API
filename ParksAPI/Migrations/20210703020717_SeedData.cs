using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "MainAttraction", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Tallest mountain on the Atlantic coast of the USA.", "Acadia", "Maine" },
                    { 34, "Shipwrecks, waterways, hiking trails.", "Isle Royale", "Michigan" },
                    { 35, "Joshua trees, sand dunes, rugged mountains.", "Joshua Tree", "California" },
                    { 36, "The Valley of Ten Thousand Smokes, an ash flow from a nearby volcanic eruption. Wildlife, sightseeing, backpacking.", "Katmai", "Alaska" },
                    { 37, "38 glaciers and fjords, Exit Glacier.", "Kenai Fjords", "Alaska" },
                    { 38, "General Grant Tree, the world's second largest measured tree.", "Kings Canyon", "California" },
                    { 39, "Kobuk River, Great Kobuk and Little Kobuk sand dunes.", "Kobuk Valley", "Alaska" },
                    { 40, "Four active volcanoes, rivers, glaciers, waterfalls.", "Lake Clark", "Alaska" },
                    { 41, "Lassen Peak, the largest lava dome volcano in the world.", "Lassen Volcanic", "California" },
                    { 42, "World's longest known cave system (400+ miles).", "Mammoth Cave", "Kentucky" },
                    { 43, "Over 4,000 archaeological sites of the Ancestral Puebloan people, including Cliff Palace and Balcony House.", "Mesa Verde", "Colorado" },
                    { 44, "Mount Rainier, the most prominent peak in the Cascades. Glaciers, climbing, backpacking.", "Mount Rainier", "Washington" },
                    { 45, "The deepest river gorge east of the Mississippi River. Whitewater rafting and sightseeing.", "New River Gorge", "West Virginia" },
                    { 46, "Hiking, climbing, backpacking. The glaciated mountains exhibit complex geologic history.", "North Cascades", "Washington" },
                    { 33, "Sandy beaches and tall dunes.", "Indiana Dunes", "Indiana" },
                    { 47, "Mount Olympus.", "Olympic", "Washington" },
                    { 49, "Massive black and gold monoliths make it a popular destination for rock climbers.", "Pinnacles", "California" },
                    { 50, "The coastal redwoods are the tallest trees on earth.", "Redwood", "California" },
                    { 51, "Wildlife, hiking trails.", "Rocky Mountain", "Colorado" },
                    { 52, "Diverse wildlife, cactus, wildflowers.", "Saguaro", "Arizona" },
                    { 53, "The largest measured tree in the park: General Sherman. Caves, the tallest mountain in the contiguous USA, Moro Rock.", "Sequoia", "California" },
                    { 54, "Part of the Skyline Drive and Appalachian Trail. 500+ miles of hiking trails.", "Shenandoah", "Virginia" },
                    { 55, "Roosevelt's historic cabin, bison, backpacking, hiking.", "Theodore Roosevelt", "North Dakota" },
                    { 56, "Beaches, mangrove forests, ruins of sugar plantations from Columbus's time.", "Virgin Islands", "U.S Virgin Islands" },
                    { 57, "Canoeing, kayaking, fishing.", "Voyageurs", "Minnesota" },
                    { 58, "The worlds largest gypsum dunefield.", "White Sands", "New Mexico" },
                    { 59, "Calcite fin formations called boxwork, a unique formation rarely found elsewhere.", "Wind Cave", "South Dakota" },
                    { 60, "Largest national park, and includes many of the continent's tallest mountains/volcanoes.", "Wrangell–St. Elias", "Alaska" },
                    { 61, "Old Faithful geyser.", "Yellowstone", "Wyoming, Montana, Idaho" },
                    { 48, "225-million-year-old petrified wood. Painted Desert, dinosaur fossils, and Native American sites.", "Petrified Forest", "Arizona" },
                    { 62, "Half Dome, El Capitan. Popular for climbers.", "Yosemite", "California" },
                    { 32, "Natural hot springs flowing out of the Ouachita Mountains.", "Hot Springs", "Arkansas" },
                    { 30, "Haleakalā volcano.", "Haleakalā", "Hawaii" },
                    { 2, "Rainforests, volcanic mountains, white beaches.", "American Samoa", "American Samoa" },
                    { 3, "Delicate Arch, Landscape Arch, and Double Arch.", "Arches", "Utah" },
                    { 4, "Buttes, fossils, the White River.", "Badlands", "South Dakota" },
                    { 5, "Chisos mountains.", "Big Bend", "Texas" },
                    { 6, "Coral reefs.", "Biscayne", "Florida" },
                    { 7, "Rock climbing.", "Black Canyon of the Gunnison", "Colorado" },
                    { 8, "Sandstone hoodoos.", "Bryce Canyon", "Utah" },
                    { 9, "Colorado River, Green River, and their tributaries.", "Canyonlands", "Utah" },
                    { 10, "Waterpocket Fold monocline.", "Capitol Reef", "Utah" },
                    { 11, "The Big Room cave.", "Carlsbad Caverns", "New Mexico" },
                    { 12, "the unique Mediterranean ecosystem.", "Channel Islands", "California" },
                    { 13, "Contains the most old-growth floodplain forest left in North America.", "Congaree", "South Carolina" },
                    { 14, "Deepest lake in the USA.", "Crater Lake", "Oregon" },
                    { 31, "Kīlauea and Mauna Loa volcanoes, two of the world's most active geological features.", "Hawaiʻi Volcanoes", "Hawaii" },
                    { 15, "Waterfalls, plus historic homes, bridges, and structures.", "Cuyahoga Valley", "Ohio" },
                    { 17, "Denali, Wonder Lake, Alaskan Range, wildlife.", "Denali", "Alaska" },
                    { 18, "Fort Jefferson, the largest masonry structure in the Western Hemisphere.", "Dry Tortugas", "Florida" },
                    { 19, "Largest tropical wilderness in the USA.", "Everglades", "Florida" },
                    { 20, "Alaskan wilderness.", "Gates of the Artic", "Alaska" },
                    { 21, "The Gateway Arch: a 630 foot high arch built to commemorate the Lewis and Clark expedition.", "Gateway Arch", "Missouri" },
                    { 22, "26 glaciers and 130 named lakes, the Rocky Mountains.", "Glacier", "Montana" },
                    { 23, "Fjords, tidewater glaciers, a temperate rainforest.", "Glacier Bay", "Alaska" },
                    { 24, "The Grand Canyon; up to a mile deep and carved by the mighty Colorado River.", "Grand Canyon", "Arizona" },
                    { 25, "Jackson Hole.", "Grand Teton", "Wyoming" },
                    { 26, "Wheeler Peak, limestone caves.", "Great Basin", "Nevada" },
                    { 27, "Tallest sand dunes in North America.", "Great Sand Dunes", "Colorado" },
                    { 28, "Over 800 miles of hiking trails.", "Great Smoky Mountains", "North Carolina, Tennessee" },
                    { 29, "Guadalupe Peak, the highest point in Texas.", "Guadalupe Mountains", "Texas" },
                    { 16, "Hottest, lowest, and driest place in the USA.", "Death Valley", "California, Nevada" },
                    { 63, "Sandstone formations, and the Virgin River", "Zion", "Utah" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 63);
        }
    }
}
