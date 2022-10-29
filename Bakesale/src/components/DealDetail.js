import React, { Component } from 'react'
import { View, Text, StyleSheet, Image, TouchableOpacity } from 'react-native'
import PropTypes from 'prop-types'
import { priceDisplay } from './util'
import ajax from '../ajax'

export default class DealDetail extends Component {
    static propTypes = {
        initialDealData: PropTypes.object.isRequired,
        onBack: PropTypes.func.isRequired,
    }
    state = {
        deal: this.props.initialDealData
    }
    async componentDidMount() {
        const fullDeal = await ajax.fetchDealDetail(this.state.deal.key)
        this.setState({ deal: fullDeal })
    }
    render() {
        const { deal } = this.state
        return (
            <View style={styles.deal}>
                <TouchableOpacity onBack={this.props.onBack}>
                    <Text style={styles.backLink}>Back</Text>
                </TouchableOpacity>
                <Image source={{ uri: deal.media[0] }} style={styles.image} />
                    <View>
                        <View style={styles.detail}>
                            <View>
                                <Text style={styles.title}>{deal.title}</Text>
                            </View>
                            <View style={styles.footer}>
                                <Text style={styles.cause}>{deal.cause}</Text>
                                <Text style={styles.price}>{priceDisplay(deal.price)}</Text>
                            </View>
                        </View>
                    </View>
                {deal.user && (
                    <View>
                        <Image source={{ uri: deal.user.avatar }} style={styles.avatar} />
                        <Text>{deal.user.name}</Text>
                    </View>
                )}
                <View style={styles.description}>
                    <View>{deal.description}</View>
                </View>
            </View>
        )
    }
}

const styles = StyleSheet.create({

    backLink: {
        marginBottom: 10,
        color: '#22f',
        marginLeft: 10
    },
    image: {
        width: '100%',
        height: 150,
        backgroundColor: '#ccc',
    },
    info: {
        borderColor: '#ddd',
        borderWidth: 1,
        borderTopWidth: 0,
    },
    title: {
        fontSize: 15,
        padding: 10,
        fontWeight: 'bold',
        backgroundColor: 'rgba(237, 149, 45, 0.4)'
    },
    footer: {
        flexDirection: 'row',
        justifyContent: 'space-around',
        alignItems: 'center',
        marginTop: 15
    },
    cause: {
    },
    price: {
        alignContent: 'flex-end'
    },
    avatar: {

    },
    description: {

    },
})
