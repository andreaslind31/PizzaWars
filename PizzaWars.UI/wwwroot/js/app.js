var app = new Vue({
    el: '#app',
    data: {
        pizzas: [],
        homePizza: [],
        counter: 0,
        winner: true,
    },
    mounted() {
        this.getData();
        this.getDataHome();
    },
    methods: {
        getData() {
            axios.get('/Pizza/Pizzas').then(res => {
                this.pizzas = res.data;
                console.log(res.data);
            }).catch(err => {
                console.log(err)
            });
        },
        getDataHome() {
            axios.get('/Home/HomePizzaImg').then(res => {
                this.homePizza = res.data;
                console.log(res.data);
            }).catch(err => {
                console.log(err)
            });
        },
        deletePizza(name) {
            this.pizzas = this.pizzas.filter(function (obj) {
                return obj.name !== name;
            });
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
            
        },
    }
})