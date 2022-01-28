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
                email: '',
                password: '',
                location_id: 0,
                primary_stores: [],
                newsletter: '',
                user_id: 0,
            }
        };
    }

    locationOptions = [
        { value: '0', label: 'Ingen' },
        { value: '1', label: 'Midtbyen gymnasium' },
    ]

    setName = (e, value) => {
        console.log(e+" "+value);
    }

    changeMultipleHandler = (e) => {
        console.log(e);
        const location_id = "location_id";
        
        this.setState({ 
            user : {
                
                [location_id] : e.value,
            }
        });
    }

    changeHandler = (e) => {
        const name = e.target.name;
        const value = e.target.value;

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
                        <label htmlFor="email">E-mail: ( bruges til brugernavn ):</label>
                        <input 
                            type="email" 
                            name="mail" 
                            value={this.state.user.email} 
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
                            name="location_id" 
                            options={this.locationOptions}
                            selectedValue={this.state.user.location_id} 
                            onChange={this.changeMultipleHandler} 
                        />
                    </p>
                    <p>
                        <label htmlFor="primary_stores">Butik: ( handle med ):</label>
                        <Select  
                            isMulti
                            name="primary_stores" 
                            options={[{label:"Kylling & Co Viborg, Gravene", value:1}]}
                            selectedValue={this.state.user.primary_stores} 
                            onChange={ (event) => this.setName('primary_stores') }  
                        />
                    </p>
                    <p>
                    <input 
                        name="newsletter" 
                        type="checkbox" 
                        id="newsletter" 
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