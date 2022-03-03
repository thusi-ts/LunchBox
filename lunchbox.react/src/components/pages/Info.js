import React, { Component } from 'react'
import { Tab, Tabs, TabList, TabPanel } from 'react-tabs';

export default class Info extends Component {

    render() {
        return (
            <div className='info-tabs'>
                <h1 className="title">Info</h1>
                <Tabs>
                    <TabList>
                        <Tab>Mario</Tab>
                        <Tab>Peach</Tab>
                        <Tab>Test</Tab>
                    </TabList>
                
                    <TabPanel>
                        <p>
                            hello
                        </p>
                    </TabPanel>
                    <TabPanel>
                        <p>
                            test1
                        </p>
                    </TabPanel>
                    <TabPanel>
                        <p>
                            test
                        </p>
                    </TabPanel>
                </Tabs>
            </div>
        )
    }
}