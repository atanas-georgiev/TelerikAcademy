var vehicle = {
    getModel: function () {
        console.log('The model of this vehicle is..' + this.model);
    }
};

var car = Object.create(vehicle, {
    'id': {
        value: MY_GLOBAL.nextId(),
        enumerable: true // writable:false, configurable:false by default
    },
    'model': {
        value: 'Ford',
        enumerable: true
    }
});
