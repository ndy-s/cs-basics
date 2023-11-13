using System;

public class Book
{
	// Class attributes
	public string title;
	public string author;
	public int pages;

	// This is a constructor (same as the name of the class)
	public Book(string aTitle, string aAuthor, int aPages)
	{
		title = aTitle;
		author = aAuthor;
		pages = aPages;
	}
}
