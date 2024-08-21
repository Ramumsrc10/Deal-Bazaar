import React from 'react';
import './HomeAndKitchen.css'; // Make sure you create/update this CSS file

export default function HomeAndKitchen() {
  const categories = [
    { title: 'Furniture', imgSrc: 'path/to/furniture.jpg' },
    { title: 'Kitchen Appliances', imgSrc: 'path/to/kitchen-appliances.jpg' },
    { title: 'Bedding', imgSrc: 'path/to/bedding.jpg' },
    { title: 'Cookware', imgSrc: 'path/to/cookware.jpg' },
    { title: 'Storage', imgSrc: 'path/to/storage.jpg' },
    { title: 'Cleaning Supplies', imgSrc: 'path/to/cleaning-supplies.jpg' },
    { title: 'Decor', imgSrc: 'path/to/decor.jpg' },
    { title: 'More', imgSrc: 'path/to/more.jpg' },
  ];

  return (
    <div className="home-kitchen-products">
      {categories.map((category, index) => (
        <div key={index} className="card">
          <img src={category.imgSrc} alt={category.title} className="card-image" />
          <div className="card-content">
            <h3 className="card-title">{category.title}</h3>
            <button className="shop-now-button">Shop Now</button>
          </div>
        </div>
      ))}
    </div>
  );
}
