using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Backend.Models;

public class ArtworkData
{
    
    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("api_model")] public string? ApiModel { get; set; }

    [JsonPropertyName("api_link")] public string? ApiLink { get; set; }

    [JsonPropertyName("is_boosted")] public bool? IsBoosted { get; set; }

    [JsonPropertyName("title")] public string? Title { get; set; }

    [JsonPropertyName("alt_titles")] public object? AltTitles { get; set; }

    [JsonPropertyName("thumbnail")] public Thumbnail? Thumbnail { get; set; }

    [JsonPropertyName("main_reference_number")] public string? MainReferenceNumber { get; set; }

    [JsonPropertyName("has_not_been_viewed_much")] public bool? HasNotBeenViewedMuch { get; set; }

    [JsonPropertyName("boost_rank")] public object? BoostRank { get; set; }

    [JsonPropertyName("date_start")] public int? DateStart { get; set; }

    [JsonPropertyName("date_end")] public int? DateEnd { get; set; }

    [JsonPropertyName("date_display")] public string? DateDisplay { get; set; }

    [JsonPropertyName("date_qualifier_title")] public string? DateQualifierTitle { get; set; }

    [JsonPropertyName("date_qualifier_id")] public int? DateQualifierId { get; set; }

    [JsonPropertyName("artist_display")] public string? ArtistDisplay { get; set; }

    [JsonPropertyName("place_of_origin")] public string? PlaceOfOrigin { get; set; }

    [JsonPropertyName("description")] public object? Description { get; set; }

    [JsonPropertyName("short_description")] public object? ShortDescription { get; set; }

    [JsonPropertyName("dimensions")] public string? Dimensions { get; set; }

    [JsonPropertyName("dimensions_detail")] public List<DimensionsDetail>? DimensionsDetail { get; set; }

    [JsonPropertyName("medium_display")] public string? MediumDisplay { get; set; }

    [JsonPropertyName("inscriptions")] public object? Inscriptions { get; set; }

    [JsonPropertyName("credit_line")] public string? CreditLine { get; set; }

    [JsonPropertyName("catalogue_display")] public string? CatalogueDisplay { get; set; }

    [JsonPropertyName("publication_history")] public object? PublicationHistory { get; set; }

    [JsonPropertyName("exhibition_history")] public object? ExhibitionHistory { get; set; }

    [JsonPropertyName("provenance_text")] public object? ProvenanceText { get; set; }

    [JsonPropertyName("edition")] public object? Edition { get; set; }

    [JsonPropertyName("publishing_verification_level")] public string? PublishingVerificationLevel { get; set; }

    [JsonPropertyName("internal_department_id")] public int? InternalDepartmentId { get; set; }

    [JsonPropertyName("fiscal_year")] public object? FiscalYear { get; set; }

    [JsonPropertyName("fiscal_year_deaccession")] public object? FiscalYearDeaccession { get; set; }

    [JsonPropertyName("is_public_domain")] public bool? IsPublicDomain { get; set; }

    [JsonPropertyName("is_zoomable")] public bool? IsZoomable { get; set; }

    [JsonPropertyName("max_zoom_window_size")] public int? MaxZoomWindowSize { get; set; }

    [JsonPropertyName("copyright_notice")] public object? CopyrightNotice { get; set; }

    [JsonPropertyName("has_multimedia_resources")] public bool? HasMultimediaResources { get; set; }

    [JsonPropertyName("has_educational_resources")] public bool? HasEducationalResources { get; set; }

    [JsonPropertyName("has_advanced_imaging")] public bool? HasAdvancedImaging { get; set; }

    [JsonPropertyName("colorfulness")] public double? Colorfulness { get; set; }

    [JsonPropertyName("color")] public Color? Color { get; set; }

    [JsonPropertyName("latitude")] public object? Latitude { get; set; }

    [JsonPropertyName("longitude")] public object? Longitude { get; set; }

    [JsonPropertyName("latlon")] public object? Latlon { get; set; }

    [JsonPropertyName("is_on_view")] public bool? IsOnView { get; set; }

    [JsonPropertyName("on_loan_display")] public object? OnLoanDisplay { get; set; }

    [JsonPropertyName("gallery_title")] public object? GalleryTitle { get; set; }

    [JsonPropertyName("gallery_id")] public object? GalleryId { get; set; }

    [JsonPropertyName("nomisma_id")] public object? NomismaId { get; set; }

    [JsonPropertyName("artwork_type_title")] public string? ArtworkTypeTitle { get; set; }

    [JsonPropertyName("artwork_type_id")] public int? ArtworkTypeId { get; set; }

    [JsonPropertyName("department_title")] public string? DepartmentTitle { get; set; }

    [JsonPropertyName("department_id")] public string? DepartmentId { get; set; }

    [JsonPropertyName("artist_id")] public int? ArtistId { get; set; }

    [JsonPropertyName("artist_title")] public string? ArtistTitle { get; set; }

    [JsonPropertyName("alt_artist_ids")] public List<object>? AltArtistIds { get; set; }

    [JsonPropertyName("artist_ids")] public List<int>? ArtistIds { get; set; }

    [JsonPropertyName("artist_titles")] public List<string>? ArtistTitles { get; set; }

    [JsonPropertyName("category_ids")] public List<string>? CategoryIds { get; set; }

    [JsonPropertyName("category_titles")] public List<string>? CategoryTitles { get; set; }

    [JsonPropertyName("term_titles")] public List<string>? TermTitles { get; set; }

    [JsonPropertyName("style_id")] public object? StyleId { get; set; }

    [JsonPropertyName("style_title")] public object? StyleTitle { get; set; }

    [JsonPropertyName("alt_style_ids")] public List<object>? AltStyleIds { get; set; }

    [JsonPropertyName("style_ids")] public List<object>? StyleIds { get; set; }

    [JsonPropertyName("style_titles")] public List<object>? StyleTitles { get; set; }

    [JsonPropertyName("classification_id")] public string? ClassificationId;

    [JsonPropertyName("classification_title")] public string? ClassificationTitle { get; set; }

    [JsonPropertyName("alt_classification_ids")] public List<string>? AltClassificationIds { get; set; }

    [JsonPropertyName("classification_ids")] public List<string>? ClassificationIds { get; set; }

    [JsonPropertyName("classification_titles")] public List<string>? ClassificationTitles { get; set; }

    [JsonPropertyName("subject_id")] public object? SubjectId { get; set; }

    [JsonPropertyName("alt_subject_ids")] public List<object>? AltSubjectIds { get; set; }

    [JsonPropertyName("subject_ids")] public List<object>? SubjectIds { get; set; }

    [JsonPropertyName("subject_titles")] public List<object>? SubjectTitles { get; set; }

    [JsonPropertyName("material_id")] public string? MaterialId { get; set; }

    [JsonPropertyName("alt_material_ids")] public List<string>? AltMaterialIds { get; set; }

    [JsonPropertyName("material_ids")] public List<string>? MaterialIds { get; set; }

    [JsonPropertyName("material_titles")] public List<string>? MaterialTitles { get; set; }

    [JsonPropertyName("technique_id")] public object? TechniqueId { get; set; }

    [JsonPropertyName("alt_technique_ids")] public List<object>? AltTechniqueIds { get; set; }

    [JsonPropertyName("technique_ids")] public List<object>? TechniqueIds { get; set; }

    [JsonPropertyName("technique_titles")] public List<object>? TechniqueTitles { get; set; }

    [JsonPropertyName("theme_titles")] public List<object>? ThemeTitles { get; set; }

    [JsonPropertyName("image_id")] public string? ImageId { get; set; }

    [JsonPropertyName("alt_image_ids")] public List<object>? AltImageIds { get; set; }

    [JsonPropertyName("document_ids")] public List<object>? DocumentIds { get; set; }

    [JsonPropertyName("sound_ids")] public List<object>? SoundIds { get; set; }

    [JsonPropertyName("video_ids")] public List<object>? VideoIds { get; set; }

    [JsonPropertyName("text_ids")] public List<object>? TextIds { get; set; }

    [JsonPropertyName("section_ids")] public List<long>? SectionIds { get; set; }

    [JsonPropertyName("section_titles")] public List<string>? SectionTitles { get; set; }

    [JsonPropertyName("site_ids")] public List<object>? SiteIds { get; set; }
    
    [JsonPropertyName("source_updated_at")] public DateTime? SourceUpdatedAt { get; set; }

    [JsonPropertyName("updated_at")] public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("timestamp")] public DateTime? Timestamp { get; set; }
}