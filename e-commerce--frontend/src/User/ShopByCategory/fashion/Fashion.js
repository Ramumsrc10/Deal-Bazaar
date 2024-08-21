import React from 'react';
import './Fashion.css';

const categories = [
  { title: "Men's Clothing", image: 'men-clothing.jpg' },
  { title: "Women's Clothing", image: 'women-clothing.jpg' },
  { title: "Footwear", image: 'footwear.jpg' },
  { title: "Accessories", image: 'accessories.jpg' },
  { title: "Jewelry", image: 'jewelry.jpg' },
  { title: "Activewear", image: 'activewear.jpg' },
  { title: "Outerwear", image: 'outerwear.jpg' },
  { title: "Sleepwear", image: 'sleepwear.jpg' },
  { title: "More", image: 'more.jpg' }
];

const Fashion = () => {
  return (
    <div className="fashion-products">
      {categories.map((category, index) => (
        <div key={index} className="card">
          <img src={category.image} alt={category.title} className="card-image" />
          <div className="card-content">
            <h3 className="card-title">{category.title}</h3>
            <button className="shop-now-button">Shop Now</button>
          </div>
        </div>
      ))}
    </div>
  );
};

export default Fashion;
