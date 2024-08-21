import React from 'react';
import Slider from 'react-slick';
import { useNavigate } from 'react-router-dom';
import './Landpage.css';
import 'slick-carousel/slick/slick.css'; // Slider styles
import 'slick-carousel/slick/slick-theme.css'; // Slider theme styles
const categories = [
  { id: 1, name: 'Electronics', image: '/images/electronics.jpg', description: 'Find the latest gadgets and electronics.' },
  { id: 2, name: 'Fashion', image: '/images/fashion.jpg', description: 'Explore the newest fashion trends.' },
  { id: 3, name: 'Home & Kitchen', image: '/images/handk.jpg', description: 'Upgrade your home and kitchen essentials.' },
  { id: 4, name: 'Sports', image: '/images/sports.jpg', description: 'Gear up for your next adventure.' },
  // Add more categories as needed
];

const Landpage = () => {
  const navigate = useNavigate();

  const settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 3,
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 2000,
  };

  const ShopNowHandler = (categoryName) => {
    if (categoryName === 'Electronics') {
      navigate("/electronics"); // Navigate to the correct route, not a file path
    }
    else if(categoryName === 'Fashion'){
        navigate("/fashion")
    }
    else if(categoryName === 'Home & Kitchen'){
        navigate("/handk")
    }
    else if(categoryName === 'Sports'){
        navigate("/sports")
    }

    // Add more conditions for other categories if needed
  };

  return (
    <div className="landpage">
      <h1 className="landpage-heading">Shop by Category</h1>
      <Slider {...settings} className="category-slider">
        {categories.map((category) => (
          <div key={category.id} className="category-slide">
            <div className="category-image-container">
              <img src={category.image} alt={category.name} className="category-image" />
            </div>
            <div className="category-info">
              <h2 className="category-title">{category.name}</h2>
              <p className="category-description">{category.description}</p>
              <span className="shopnow">
                <button className="category-button" onClick={() => ShopNowHandler(category.name)}>
                  Shop Now
                </button>
              </span>
            </div>
          </div>
        ))}
      </Slider>
    </div>
  );
};

export default Landpage;
