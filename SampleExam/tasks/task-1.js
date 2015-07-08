function solve() {
    'use strict';
    var module = (function() {

        var CONSTANTS = {
            MIN_STRING_LEN: 3,
            MAX_STRING_LEN: 25
        };

        var validators = {
            // String
            isString: function(value) {
                return (typeof value === 'string' || value instanceof String);
            },
            checkStringAndThrow: function(value) {
                if (!this.isString(value)) {
                    throw new Error(value + ' not a string!');
                }
            },
            checkTitleLength: function(value) {
                if (value.length < CONSTANTS.MIN_STRING_LEN ||
                    value.length > CONSTANTS.MAX_STRING_LEN) {
                    throw new Error(value + ' length not correct!');
                }
            },
            // Number
            isNumber: function(value) {
                return !isNaN(parseFloat(value)) && isFinite(value);
            },
            checkNumberAndThrow: function(value) {
                if (!this.isNumber(value)) {
                    throw new Error(value + ' not a number!');
                }
            },
            // others
            getById: function(collection, id) {
                if (collection === undefined || id === undefined) {
                    throw new Error();
                }

                var i, len;
                for (i = 0, len = collection.length; i < len; i++) {
                    if (collection[i].id == id) {
                        return collection[i];
                    }
                }

                return null;
            },
            getIndexById: function(collection, id) {
                if (collection === undefined || id === undefined) {
                    throw new Error();
                }

                var i, len;
                for (i = 0, len = collection.length; i < len; i++) {
                    if (collection[i].id == id) {
                        return i;
                    }
                }

                return null;
            },
            checkForIdAndThrow: function(value) {
                if (value === undefined || typeof value !== 'object' || value.id === undefined) {
                    throw new Error();
                }
            },
        };

        var playable = (function() {
            // Private functions
            var playableInternal = Object.create({}),
                idPlayable = 0;

            Object.defineProperties(playableInternal, {
                'init': {
                    value: function(title, author) {
                        this._id = ++idPlayable;
                        this.title = title;
                        this.author = author;
                        return this;
                    }
                },
                'id': {
                    get: function() {
                        return this._id;
                    }
                },
                'title': {
                    get: function() {
                        return this._title;
                    },
                    set: function(value) {
                        validators.checkStringAndThrow(value);
                        validators.checkTitleLength(value);
                        this._title = value;
                    }
                },
                'author': {
                    get: function() {
                        return this._auther;
                    },
                    set: function(value) {
                        validators.checkStringAndThrow(value);
                        validators.checkTitleLength(value);
                        this._auther = value;
                    }
                },
                'play': {
                    value: function() {
                        return this.id + '.' + this.title + ' - ' + this.author;
                    }
                }
            });
            return playableInternal;
        }());

        var audio = (function(parent) {
            var audioInternal = Object.create(parent);

            Object.defineProperties(audioInternal, {
                'init': {
                    value: function(title, author, length) {
                        parent.init.call(this, title, author);
                        this.length = length;
                        return this;
                    }
                },
                'length': {
                    get: function() {
                        return this._length;
                    },
                    set: function(value) {
                        validators.checkNumberAndThrow(value);
                        if (value <= 0) {
                            throw new Error();
                        }
                        this._length = value;
                    }
                },
                'play': {
                    value: function() {
                        return parent.play.call(this) + ' - ' + this.length;
                    }
                }
            });
            return audioInternal;
        }(playable));

        var video = (function(parent) {
            var videoInternal = Object.create(parent);

            Object.defineProperties(videoInternal, {
                'init': {
                    value: function(title, author, imdbRating) {
                        parent.init.call(this, title, author);
                        this.imdbRating = imdbRating;
                        return this;
                    }
                },
                'imdbRating': {
                    get: function() {
                        return this._imdbRating;
                    },
                    set: function(value) {
                        validators.checkNumberAndThrow(imdbRating);
                        if (value < 1 || value > 5) {
                            throw new Error();
                        }
                        this._imdbRating = value;
                    }
                },
                'play': {
                    value: function() {
                        return parent.play.call(this) + ' - ' + this.imdbRating;
                    }
                }
            });
            return videoInternal;
        }(playable));

        var playlist = (function() {
            var playlistInternal = {},
                idPlaylist = 0;

            Object.defineProperties(playlistInternal, {
                'init': {
                    value: function(name) {
                        this.name = name;
                        this._id = ++idPlaylist;
                        this._playables = [];
                        return this;
                    }
                },
                'id': {
                    get: function() {
                        return this._id;
                    }
                },
                'name': {
                    get: function() {
                        return this._name;
                    },
                    set: function(value) {
                        validators.checkStringAndThrow(value);
                        validators.checkTitleLength(value);
                        this._name = value;
                    }
                },
                'addPlayable': {
                    value: function(playableValue) {
                        var res;
                        validators.checkForIdAndThrow(playableValue);
                        res = validators.getById(this._playables, playableValue.id);
                        if (res === null) {
                            this._playables.push(playableValue);
                        }
                        return this;
                    }
                },
                'getPlayableById': {
                    value: function(id) {
                        return validators.getById(this._playables, id);
                    }
                },
                'removePlayable': {
                    value: function(id) {
                        if (validators.isNumber(id) !== true) {
                            id = id.id;
                        }

                        var index = validators.getIndexById(this._playables, id);
                        if (index === null) {
                            throw new Error();
                        }

                        this._playables.splice(index, 1);

                        return this;
                    }
                },
                'listPlayables': {
                    value: function(page, size) {
                        validators.checkNumberAndThrow(page);
                        validators.checkNumberAndThrow(size);

                        if (page * size > this._playables.length || page < 0 || size <= 0) {
                            throw new Error();
                        }

                        return this
                            ._playables
                            .slice()
                            .sort(function(item1, item2) {
                                if (item1.name > item2.name) {
                                    return 1;
                                } else if (item1.name < item2.name) {
                                    return -1;
                                } else {
                                    return item2.id - item1.id;
                                }
                            }).splice(page * size, size);
                    }
                }
            });

            return playlistInternal;
        }());

        var player = (function() {
            var playerInternal = {},
                idPlayer;

            Object.defineProperties(playerInternal, {
                'init': {
                    value: function(name) {
                        this.name = name;
                        this._id = ++idPlayer;
                        this._playlists = [];
                        return this;
                    }
                },
                'id': {
                    get: function() {
                        return this._id;
                    }
                },
                'name': {
                    get: function() {
                        return this._name;
                    },
                    set: function(value) {
                        validators.checkStringAndThrow(value);
                        validators.checkTitleLength(value);
                        this._name = value;
                    }
                },
                'addPlaylist': {
                    value: function(playlistToAdd) {
                        var res;
                        validators.checkForIdAndThrow(playlistToAdd);
                        res = validators.getById(this._playlists, playlistToAdd.id);
                        if (res === null) {
                            this._playlists.push(playlistToAdd);
                        }
                        return this;
                    }
                },
                'getPlaylistById': {
                    value: function(id) {
                        return validators.getById(this._playlists, id);
                    }
                },
                'removePlaylist': {
                    value: function(id) {
                        if (validators.isNumber(id) !== true) {
                            id = id.id;
                        }

                        var index = validators.getIndexById(this._playlists, id);
                        if (index === null) {
                            throw new Error();
                        }

                        this._playlists.splice(index, 1);

                        return this;
                    }
                },
                'listPlaylists': {
                    value: function(page, size) {
                        validators.checkNumberAndThrow(page);
                        validators.checkNumberAndThrow(size);

                        if (page * size > this._playlists.length || page < 0 || size <= 0) {
                            throw new Error();
                        }

                        return this
                            ._playlists
                            .slice()
                            .sort(function(item1, item2) {
                                if (item1.name > item2.name) {
                                    return 1;
                                } else if (item1.name < item2.name) {
                                    return -1;
                                } else {
                                    return item2.id - item1.id;
                                }
                            }).splice(page * size, size);
                    }
                },
                'contains': {
                    value: function(playable, playlist) {
                        validator.checkForIdAndThrow(playable);
                        validator.checkForIdAndThrow(playlist);
                        var playableId = playable.id;
                        var playlistId = playlist.id;

                        var playlist1 = validators.getById(this._playlists, playlistId);
                        if (playlist1 === null) {
                            return false;
                        }

                        var playable1 = validators.getById(playlist1, playlistId);
                        if (playable1 === null) {
                            return false;
                        }

                        return true;
                    }
                },
                'search': {
                    value: function(pattern) {

                    }
                }
            });
            return playerInternal;
        }());

        return {
            getPlayer: function(name) {
                return Object.create(player).init(name);
            },
            getPlaylist: function(name) {
                return Object.create(playlist).init(name);
            },
            getAudio: function(title, author, length) {
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function(title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating);
            }
        };

    })();

    return module;
}

module.exports = solve;
