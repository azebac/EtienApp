import { Base } from './base';

export class Preference extends Base {
    private Name: string;

    /**
     * Getter $Name
     * @return {string}
     */
	public get $Name(): string {
		return this.Name;
	}

    /**
     * Setter $Name
     * @param {string} value
     */
	public set $Name(value: string) {
		this.Name = value;
	}


	constructor(data?) {
        super(data);
        if(data){
        this.Name = data.Name || "";
        }
    }
    
}
