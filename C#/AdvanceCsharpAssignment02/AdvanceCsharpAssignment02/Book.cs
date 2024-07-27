using System;

namespace AdvanceCsharpAssignment02
{
    internal class Book
    {
        private string isbn;
        private string title;
        private string[] authors;
        private DateTime publicationDate;
        private decimal price;

        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    isbn = value;
                }
                else
                {
                    throw new ArgumentException("ISBN cannot be null or empty.");
                }
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    title = value;
                }
                else
                {
                    throw new ArgumentException("Title cannot be null or empty.");
                }
            }
        }

        public string[] Authors
        {
            get { return authors; }
            set
            {
                if (value is not null && value.Length > 0)
                {
                    authors = value;
                }
                else
                {
                    throw new ArgumentException("Authors cannot be null or empty.");
                }
            }
        }

        public DateTime PublicationDate
        {
            get { return publicationDate; }
            set { publicationDate = value; }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Price must be greater than zero.");
                }
            }
        }

        public Book(string isbn, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString()
        {
            string authorsList = string.Join(", ", Price);
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {authorsList}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
        }
    }
}
