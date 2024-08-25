## Your Name: HOMEWORK 6 SOLUTION

# CIDM 3312 Homework 6: Product Reviews

In this homework you will build on Lab 10 and create a Bootstrap Home Page that shows all products and their reviews. Your page will have a review star system that shows the average total review score and use other advanced Bootstrap UI capabilities to build a professional web page. You will also implement a razor page to add new reviews all according to the requirements below.

The goal of this homework is to practice building an ASP.NET Core + EF Core web app and also practice Bootstrap on the frontend. You will combine your Bootstrap knowledge with EF Core and database capabilities.

## Task 1: Start with a complete lab 10
1. Start with a complete version of lab 10. You can copy your existing code or re-run the steps. If you copy code, make sure to update your namespaces and using directives.

## Task 2: Build Bootstrap Home Page
1. Update the main index page model (`Pages/Index.cshtml.cs`) to bring in the reviews using `.Include()`.
2. Update the main index razor page (`Pages/Index.cshtml`) to use a `@foreach` loop to display each product in a row. Here is what the final web page should look like. Reference this image as you are completing your tasks to make sure the UI matches:

![Complete Webpage](https://i.imgur.com/IEBLLVs.png)

3. The Show Reviews button will expand/collapse the reviews and scores for each product. You will implement that in Task 4. Here is an image with all the reviews shown:

![Complete Webpage with Reviews](https://i.imgur.com/8t6EaVL.png)

4. Match the following UI requirements for each row. Start with a `<div class="row">` before the two columns inside the row:

![UI For Row](https://i.imgur.com/Bfd9EuF.png)

## Task 3: Implement Stars for Reviews
1. Some code to implement the stars showing the review average will be slightly new. I will explain that here.
2. Within the razor page you must calculate the review average score and the number of reviews. LINQ provides that functionality with this code:
  ```
    double reviewAvg = p.Reviews.Average(r => r.Score);
    double reviewCnt = p.Reviews.Count;
  ```
Place that code within the `@foreach` loop on the razor page. The variable `reviewAvg` will now contain the average review score like 3.5 and `reviewCnt` will contain the number of reviews. The variable `p` represents a single product and should match the variable you used to setup your `@foreach` loop.
3. Use the following HTML/Bootstrap structure to display the review average, stars, and count:
```
<p>
  <span>@String.Format("{0:F1}", reviewAvg) </span> <!-- Display review average formatted to 1 decimal place -->
  <!-- place code here to display star icons (Filled in star, half star, and empty star) -->
  <span>@reviewCnt reviews</span> <!-- Display number of reviews -->
</p>
```
4. Use Bootstrap Icons to display each type of star. Use a filled in gold star, a half gold star for partial scores, and an empty star for the rest. Each product should have 5 stars and then filled in up to the review average. For example, an average of 3.0 should fill in 3 stars and have 2 empty stars. A score of 3.1 should fill in 3 stars, 1 half-filled star, and 1 empty star. Any fractional score should be represented by a half-star. Here are the Bootstrap icons to use:
```
<i class="bi bi-star-fill" style="color: gold;"></i> <!-- Filled in star colored Gold -->
<i class="bi bi-star-half" style="color: gold;"></i> <!-- Half star colored gold -->
<i class="bi bi-star"></i> <!-- Empty star -->
```
It is up to you to figure out an algorithm to use to complete this. Starting with a `@for` loop will be helpful.

## Task 4: Implement Show Reviews
1. Each product has a button to Show Reviews. Clicking that button should expand the area below the product and display the full reviews and score. You will use the Bootstrap Collapse feature to accomplish this (https://getbootstrap.com/docs/5.3/components/collapse/).
2. Your code should look similar to this:
```
<button class="btn btn-primary" type="button" data-bs-toggle="collapse" data-bs-target="@("#reviews" + @p.ProductID)">Show Reviews</button>
<div class="collapse" id="@("reviews" + @p.ProductID)">
  <!-- Write code here to display reviews -->
</div>
```
The code "@("reviews" + @p.ProductID)" gives each collapsable div a unique id like "reviews1" for Product 1 and "reviews2" for Product 2. This way each button works on its own product and set of reviews. This is a good razor page coding technique to remember.

## Task 5: Build an Add Review Page
1. Make an add review page that can successfully add a new review.
2. Create a link within `_Layout.cshtml` for Add Review.
3. Your Add Review page should perform full data validation and look like this. Update `[Display(Name = "")]` data validation rules to match this screenshot:

![Add New Review](https://i.imgur.com/IBnFTgo.png)

## Task 6: Test your Web App and Submit
1. Test that your stars match the review average score accurately and show half-stars for fractional scores.
2. Add new reviews and ensure review averages, stars, counts all update on the home page.
3. When you are finished, submit your assignment to GitHub.
