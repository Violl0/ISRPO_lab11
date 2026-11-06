public class book {
    public string Name;
    public int Count { get; private set; }
    public string Genre;
    public int Price;
    public bool Availability;

    public book(string name, int count, string genre, int price) {
        Name = name;

        Count = count;

        if (Count < 0) {
            Count = 0;
        }

        Genre = genre;
        Price = price;
        Availability = true;
    }

    public void Restock(int amount) {
        if (amount <= 0) {
            return;
        }

        Count += amount;
    }
}