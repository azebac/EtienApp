import { Base } from './base';
import { Country } from './country';
import { Preference } from './preference';

export class User extends Base {
    private Name: string;
    private LastName: string;
    private UserName: string;
    private PassWord: string;
    private Email: string;
    private UserDeviceId: string;
    private Cellphone: string;
    private Gender: number;
    private Status: number;
    private AppToken: string;
    private Country: Country;
    private Preferences: Preference[] = [];

    constructor(data?) {
        super(data);
        if (data) {
            this.Name = data.Name || "";
            this.LastName = data.LastName || "";
            this.UserName = data.UserName || "";
            this.PassWord = data.PassWord || "";
            this.Email = data.Email || "";
            this.UserDeviceId = data.UserDeviceId || "";
            this.Cellphone = data.Cellphone || "";
            this.Gender = data.Gender || 1;
            this.Status = data.Status || 1;
            this.Country = data.Country || null;
            this.AppToken = data.AppToken || "";
            if (data.Preferences != undefined) {
                data.Preferences.forEach(element => {
                    let preference = new Preference(element);
                    this.Preferences.push(preference);
                });
            }
            else {
                this.Preferences = [];
            }
        }
    }


    /**
     * Getter $Name
     * @return {string}
     */
    public get $Name(): string {
        return this.Name;
    }

    /**
     * Getter $LastName
     * @return {string}
     */
    public get $LastName(): string {
        return this.LastName;
    }

    /**
     * Getter $UserName
     * @return {string}
     */
    public get $UserName(): string {
        return this.UserName;
    }

    /**
     * Getter $PassWord
     * @return {string}
     */
    public get $PassWord(): string {
        return this.PassWord;
    }

    /**
     * Getter $Email
     * @return {string}
     */
    public get $Email(): string {
        return this.Email;
    }

    /**
     * Getter $UserDeviceId
     * @return {string}
     */
    public get $UserDeviceId(): string {
        return this.UserDeviceId;
    }

    /**
     * Getter $Cellphone
     * @return {string}
     */
    public get $Cellphone(): string {
        return this.Cellphone;
    }

    /**
     * Getter $Gender
     * @return {number}
     */
    public get $Gender(): number {
        return this.Gender;
    }

    /**
     * Getter $Status
     * @return {number}
     */
    public get $Status(): number {
        return this.Status;
    }

    /**
     * Getter $Country
     * @return {Country}
     */
    public get $Country(): Country {
        return this.Country;
    }

    /**
     * Getter $Preferences
     * @return {Preference[] }
     */
    public get $Preferences(): Preference[] {
        return this.Preferences;
    }

    /**
     * Setter $Name
     * @param {string} value
     */
    public set $Name(value: string) {
        this.Name = value;
    }

    /**
     * Setter $LastName
     * @param {string} value
     */
    public set $LastName(value: string) {
        this.LastName = value;
    }

    /**
     * Setter $UserName
     * @param {string} value
     */
    public set $UserName(value: string) {
        this.UserName = value;
    }

    /**
     * Setter $PassWord
     * @param {string} value
     */
    public set $PassWord(value: string) {
        this.PassWord = value;
    }

    /**
     * Setter $Email
     * @param {string} value
     */
    public set $Email(value: string) {
        this.Email = value;
    }

    /**
     * Setter $UserDeviceId
     * @param {string} value
     */
    public set $UserDeviceId(value: string) {
        this.UserDeviceId = value;
    }

    /**
     * Setter $Cellphone
     * @param {string} value
     */
    public set $Cellphone(value: string) {
        this.Cellphone = value;
    }

    /**
     * Setter $Gender
     * @param {number} value
     */
    public set $Gender(value: number) {
        this.Gender = value;
    }

    /**
     * Setter $Status
     * @param {number} value
     */
    public set $Status(value: number) {
        this.Status = value;
    }

    /**
     * Setter $Country
     * @param {Country} value
     */
    public set $Country(value: Country) {
        this.Country = value;
    }

    /**
     * Setter $Preferences
     * @param {Preference[] } value
     */
    public set $Preferences(value: Preference[]) {
        this.Preferences = value;
    }


    /**
     * Getter $AppToken
     * @return {string}
     */
	public get $AppToken(): string {
		return this.AppToken;
	}

    /**
     * Setter $AppToken
     * @param {string} value
     */
	public set $AppToken(value: string) {
		this.AppToken = value;
	}




}
