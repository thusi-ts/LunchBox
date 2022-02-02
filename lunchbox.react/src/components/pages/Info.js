import React, { Component } from 'react'
import { Tab, Tabs, TabList, TabPanel } from 'react-tabs';

export default class Info extends Component {

    constructor(props){
        
        super(props);
        
    }

    render() {

        const tabs = 
            <Tabs>
              <TabList>
                <Tab>Mario</Tab>
                <Tab disabled>Luigi</Tab>
                <Tab>Peach</Tab>
              </TabList>
          
              <TabPanel>
                <p>
                  hello
                </p>
                <p>
                  Source:{' '}
                  
                </p>
              </TabPanel>
              <TabPanel>
                <p>
                  test1
                </p>
                <p>
                  Source:{' '}
                  
                </p>
              </TabPanel>
              <TabPanel>
                <p>
                  test
                </p>
                <p>
                  Source:{' '}
                  
                </p>
              </TabPanel>
             
            </Tabs>


        return (
            <div>
                { tabs }
            </div>
        )
    }
}