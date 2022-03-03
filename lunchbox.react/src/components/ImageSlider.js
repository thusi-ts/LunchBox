import React, { Component } from 'react'

export default class ImageSlider extends Component {

    constructor(props) {
        super(props);
        this.state = {
          current: 0
        };
    }

    nextImage = () => {
        let lenght = this.sliderData().length;
        let current = this.state.current;

        this.setState({
            current : (current === lenght - 1 ? 0 : current + 1)
        });
    }

    prevImage = () => {
        let lenght = this.sliderData().length;
        let current = this.state.current;

        this.setState({
            current : (current === 0 ? lenght - 1 : current - 1)
        });
    }

    sliderData = () => {
        return [
            {
                image : 'http://www.lunchbox.dk/assets/images/news-slider/slide2.jpg'    
            }, 
            {
                image : 'http://www.lunchbox.dk/assets/images/news-slider/slide1.png'    
            },
        ]
    }

    componentDidMount() { 
        this.nextImage();
    }

    componentDidUpdate() { 
        setTimeout(() => { 
            this.nextImage();
        }, 5000);
    }


    render() {

        const sliderData = this.sliderData();
        let current = this.state.current;

        if (!Array.isArray(sliderData) || sliderData.length <= 0) {
            return null;
        }

        return (
            <section className="slider">
                {sliderData.map((slide, index) => {
                    return (
                        <div className={current === index ? 'slide active' : 'slide'} key={index}>
                            {index === current && (<img src={slide.image} alt={slide.image} className="image" />)}
                        </div>
                    )
                })}
            </section>
        )
    }
}
