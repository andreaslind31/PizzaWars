'use strict';


//a component’s data option must be a function,
//so that each instance can maintain an independent copy of the returned data object:
Vue.component('add-sauces', {
    data: function () {
        return {
            count: 0,
        }
    },
    template: '<button class="btn btn-light" v-on:click="count++">Click to add sauce: {{ count }}</button>'
})
Vue.component('add-toppings', {
    props: ['topping'],
    template: `
    <div class="add-toppings">
      <p>{{ topping.text }}</p>
      <div v-html="topping.content"></div>
    </div>
    `
})
Vue.component('message-component', {
    data: function () {
            return {
                message: 'show additional toppings'
        }
        if (message == 'additional toppings listed') {
            this.isToppingsShown = true;
            return console.log(this.isToppingsShown);
        }
        
    },
    template: `
    <button class="btn btn-info" v-on:click="message = 'additional toppings listed'">
     {{ message }}
    </button>
    `
})

var app = new Vue({
    el: '#app',
    data: {
        isToppingsShown : false,
        message: 'You loaded this page on ' + new Date().toLocaleString(),
        pizzas: [],
        homePizza: [],
        counter: 0,
        winner: false,
        selected: '',
        additionalToppings: [
            { id: 0, text: "Moooore Tomatoes" },
            { id: 1, text: "Cheeseuzz" },
            { id: 2, text: "Ham-string me" },
            { id: 3, text: "Shruuuuums" },
            { id: 4, text: "Shrimpsus" },
            { id: 5, text: "Pineapple-me" },
            { id: 6, text: "Beer?" },
        ]
    },
    mounted() {
        this.getData();
    },
    methods: {
        getData() {
            axios.get('/Pizza/Pizzas').then(res => {
                this.pizzas = res.data;
                console.log(res.data);
            }).catch(err => {
                console.log(err)
            });
            this.counter = 0;
            this.winner = false;
        },
        deletePizza(name) {
            this.pizzas = this.pizzas.filter(function (obj) {
                return obj.name !== name;
            });
            this.counter++;
        },
        winnerPizza(name) {
            this.pizzas = this.pizzas.filter(function (obj) {
                obj.hypeLevel++;
                return obj.name === name;
            });
            console.log(this.pizzas.name);
            if (this.counter < 10) {
                this.counter++;
            }
            this.winner = true;
        },
    }
})