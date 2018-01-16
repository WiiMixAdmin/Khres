export class Position {   

    constructor(private id:Number, private title:String) {

    }
    
    getId() {
        return this.id;
    }

    getTitle() {
        return this.title;
    }
}