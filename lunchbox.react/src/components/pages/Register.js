import React, { Component } from 'react'
import Select from 'react-select'

export default class Register extends Component {

    constructor(props){
        
        super(props);
        this.state = {
            user : {
                fullname: '',
                street: '',
                zipcode: '',
                city: '',
                phone: '',
                mail: '',
                password: '',
                location_id: 0,
                primary_stores: [],
                newsletter: false,
                user_id: 0,
            }
        };

        this.changeLocationHandler = this.changeLocationHandler.bind(this);
        this.changeStoresHandler = this.changeStoresHandler.bind(this);
        this.checkNewsletterHandler = this.checkNewsletterHandler.bind(this);
        this.changeHandler = this.changeHandler.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        
    }

    locationOptions = [
        { value: '0', label: 'Ingen' },
        { value: '1', label: 'Midtbyen gymnasium' },
        { value: '2', label: 'Midtbyen gymnasium test' },
    ]

    changeLocationHandler = (e) => {
        
        const location_id = "location_id";

        this.setState({ 
            user : {
                ...this.state.user, 
                [location_id] : e.value,
            }
        });
    }

    changeStoresHandler = (event) => {

        const stores_ids = "primary_stores";
        const selectedValues = (Array.isArray(event) ? event.map(x => new { value: x.value, label: x.label }) : [] );
        
        this.setState({ 
            user : {
                ...this.state.user, 
                [stores_ids] : selectedValues,
            }
        });
    }

    checkNewsletterHandler(e){

        const name = e.target.name;
        const value = e.target.checked;
        
        const newsletterValue = ((value == true) ? true : false);

        this.setState({ 
            user : {
                ...this.state.user, 
                [name] : newsletterValue,
            }
        });
    }

    changeHandler = (e) => {
        const name = e.target.name;
        const value = e.target.value;

        console.log(this.state.user+" "+name);

        this.setState({
            user : {
                ...this.state.user, 
                [name] : value,
            }
        });
    }

    handleSubmit = (event) => {
        event.preventDefault();
        console.log(this.state.user);
    };

    render(){
        return (
            <div className="registration form">
                <h1 className="title">Bruger</h1>

                <div className="">
                <form onSubmit={this.handleSubmit} >
                    
                    <p>
                        <label htmlFor="fullname">Navn:</label>
                        <input 
                            type="text" 
                            name="fullname" 
                            value={this.state.user.fullname} 
                            onChange={this.changeHandler}
                            required 
                        /> 
                    </p>
                    
                    <p>
                        <label htmlFor="street">Adresse:</label>
                        <input 
                            type="text" 
                            name="street" 
                            value={this.state.user.street} 
                            onChange={this.changeHandler}
                            required 
                        /> 
                    </p>
                    
                    <p>
                        <label htmlFor="zipcode">Postnr.:</label>
                        <input 
                            type="text" 
                            name="zipcode" 
                            value={this.state.user.zipcode} 
                            onChange={this.changeHandler}
                            required 
                        />
                    </p>
                    
                    <p>
                        <label htmlFor="city">By:</label>
                        <input 
                            type="text" 
                            name="city" 
                            value={this.state.user.city} 
                            onChange={this.changeHandler}
                            required 
                        />
                    </p>
                    
                    <p>
                        <label htmlFor="phone">Mobilnr.:</label>
                        <input 
                            type="tel" 
                            name="phone" 
                            value={this.state.user.phone} 
                            onChange={this.changeHandler}
                            required 
                        />
                    </p>
                    
                    <p>
                        <label htmlFor="mail">E-mail: ( bruges til brugernavn ):</label>
                        <input 
                            type="email" 
                            name="mail" 
                            value={this.state.user.mail} 
                            onChange={this.changeHandler}
                            required 
                        />
                    </p>
                    <p>
                        <label htmlFor="password">Vælg adgangskode:</label>
                        <input 
                            type="password" 
                            name="password" 
                            placeholder="Min. 4 tegn" 
                            value={this.state.user.password} 
                            onChange={this.changeHandler}
                            required 
                        />
                    </p>
                    
                    <p>
                        <label htmlFor="location_id">Din Institution:</label>
                        <Select 
                            options={this.locationOptions}
                            defaultValue={this.state.user.location_id} 
                            onChange={this.changeLocationHandler} 
                        />
                    </p>
                    <p>
                        <label htmlFor="primary_stores">Butik: ( handle med ):</label>
                        <Select  
                            isMulti
                            options={[{label:"Kylling & Co Viborg, Gravene", value:1}, {label:"Kylling & Co Viborg, Gravene test", value:2}]}
                            defaultValue={this.state.user.primary_stores} 
                            onChange={this.changeStoresHandler} 
                        />
                    </p>
                    <p>
                        <input 
                            type="checkbox" 
                            name="newsletter" 
                            onChange={this.checkNewsletterHandler} 
                            checked={this.state.user.newsletter}
                        />
                    <label htmlFor="newsletter"> Nyhedsbrev: ( Send mig de bedste deals og nyt om restauranten ):</label>
                    </p>
                    <p>
                        <input 
                            type="submit" 
                            value="Gem bruger" 
                            className="submitbtn" 
                        />
                    </p>
                    
                    <input 
                        type="hidden" 
                        name="user_id" 
                        value={this.state.user.user_id}  
                    />
                    </form>
                </div>
            </div>
        )
    }
}