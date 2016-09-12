import { Injectable } from '@angular/core';
import { HttpService }  from '../http.service';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/Rx'
import { Blog }  from './blog';

@Injectable()

export class BlogService {
    constructor(private http: HttpService<Blog>) { }

    getAll() {
        return this.http.get("api/blog");
    }

    getById(id: any) {
        return this.http.get("api/blog/"+ id);
    }

    AddBlog(blog: any) {
        return this.http.post("api/blog/add", blog);
    }

    UpdateBlog(blog: any) {
        return this.http.put("api/blog/update", blog);
    }

    DeleteBlog(id: any) {
        return this.http.delete("api/blog/delete/" + id);
    }
}