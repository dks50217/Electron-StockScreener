const router = new VueRouter({
    routes: [
        {
            path: '/',
            name: 'index',
            component: httpVueLoader('../components/my-component.vue')
        }
    ]
})