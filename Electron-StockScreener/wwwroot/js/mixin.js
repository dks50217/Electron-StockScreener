const mixin = {
    data: function () {
        return {
            message: 'hello'
        }
    },
    methods: {
        mixinTest() {
            console.log('mixinTest');
        },
        sleep(ms) {
            return new Promise(resolve => setTimeout(resolve, ms));
        },
        callWebAPI(oUrl, oData) {
            const request = axios({
                method: 'POST',
                url: oUrl,
                data: oData
            }).then(function (response) {
                return response.data;
            }).catch(function (error) {
                console.log(error)
            })

            return {
                load: request
            };
        }
    }
}