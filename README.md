# TheatreCMS3
 C# and .NET Capstone Project

 #User Story 3: User would like to be able to store the information for multiple blog writers/authors that work for the theater.

I navigated through the project and saw that pages were already scaffolded within the Areas\Blog\Views folder

#User Story 3 Updated: User would like the ability to create blog posts from within the BlogAuthorIndex

1. Created the BlogPost Model & inlcuded the following properties:
	
	*BlogPostId (primary key)
	*Title
	*Content
	*CreatedAt (with default value)
	*AuthorId (foreign key)
	*BlogAuthor (navigation property for relationship)

## Purpose:
* To represent blog post entities and establish a one-to-many relationship with BlogAuthor.**
**
2. Registered BlogPost in ApplicationDbContext
* Added a DbSet<BlogPost> property to ApplicationDbContext inside IdentityModels.cs.

**Purpose:
To enable Entity Framework to track and manage BlogPost entities, and to include them in migrations.

3. Created a Migration and Updated the Database
* Ran Add-Migration AddBlogPost
* Followed by Update-Database

##Purpose:
To create the corresponding BlogPosts table in the SQL Server LocalDb database schema.

4. Scaffolded BlogPostsController with Views
Used Visual Studio scaffolding to generate:

* BlogPostsController.cs
* CRUD views: Index, Create, Edit, Details, Delete

*** The scaffold automatically generated form fields and routing conventions for managing BlogPost entities.

5. Integrated Author Selection into BlogPost Creation
(Discovered scaffolded Create/Edit views already handled Author selection via dropdown)

6. Added Shortcut Button for Creating Posts from BlogAuthors Page
Identified that the BlogAuthors listing view used a partial view:


### Result:  
A working end-to-end implementation allowing:

* Creation, editing, and management of BlogPost entities
* Association of blog posts with authors via foreign key relationships
* Shortcut navigation for blog post creation directly from the BlogAuthors listing page


