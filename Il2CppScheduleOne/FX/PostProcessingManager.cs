using System;
using Il2CppBeautify.Universal;
using Il2CppCorgiGodRays;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003F9 RID: 1017
	public class PostProcessingManager : Singleton<PostProcessingManager>
	{
		// Token: 0x060054B2 RID: 21682 RVA: 0x0018C9A8 File Offset: 0x0018ABA8
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingManager()
		{
			Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PostProcessingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr);
			PostProcessingManager.NativeFieldInfoPtr_GlobalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "GlobalVolume");
			PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "Vig_DefaultIntensity");
			PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "Vig_DefaultSmoothness");
			PostProcessingManager.NativeFieldInfoPtr_MinBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "MinBlur");
			PostProcessingManager.NativeFieldInfoPtr_MaxBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "MaxBlur");
			PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ChromaticAberrationController");
			PostProcessingManager.NativeFieldInfoPtr_SaturationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "SaturationController");
			PostProcessingManager.NativeFieldInfoPtr_BloomController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "BloomController");
			PostProcessingManager.NativeFieldInfoPtr_ColorFilterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ColorFilterController");
			PostProcessingManager.NativeFieldInfoPtr_vig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "vig");
			PostProcessingManager.NativeFieldInfoPtr_DoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "DoF");
			PostProcessingManager.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "GodRays");
			PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ColorAdjustments");
			PostProcessingManager.NativeFieldInfoPtr_beautifySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "beautifySettings");
			PostProcessingManager.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "bloom");
			PostProcessingManager.NativeFieldInfoPtr_chromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "chromaticAberration");
			PostProcessingManager.NativeFieldInfoPtr_colorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "colorAdjustments");
			PostProcessingManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673835);
			PostProcessingManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673836);
			PostProcessingManager.NativeMethodInfoPtr_UpdateEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673837);
			PostProcessingManager.NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673838);
			PostProcessingManager.NativeMethodInfoPtr_ResetVignette_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673839);
			PostProcessingManager.NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673840);
			PostProcessingManager.NativeMethodInfoPtr_SetContrast_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673841);
			PostProcessingManager.NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673842);
			PostProcessingManager.NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673843);
			PostProcessingManager.NativeMethodInfoPtr_SetBlur_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673844);
			PostProcessingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673845);
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x0018CC08 File Offset: 0x0018AE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180184, XrefRangeEnd = 180216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x0018CC44 File Offset: 0x0018AE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180216, XrefRangeEnd = 180217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x0018CC78 File Offset: 0x0018AE78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180226, RefRangeEnd = 180227, XrefRangeStart = 180217, XrefRangeEnd = 180226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_UpdateEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x0018CCAC File Offset: 0x0018AEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180228, RefRangeEnd = 180229, XrefRangeStart = 180227, XrefRangeEnd = 180228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideVignette(float intensity, float smoothness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x0018CCF8 File Offset: 0x0018AEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180229, XrefRangeEnd = 180230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVignette()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_ResetVignette_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x0018CD2C File Offset: 0x0018AF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180230, XrefRangeEnd = 180231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGodRayIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x0018CD6C File Offset: 0x0018AF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180231, XrefRangeEnd = 180232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContrast(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetContrast_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x0018CDAC File Offset: 0x0018AFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180232, XrefRangeEnd = 180234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSaturation(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x0018CDEC File Offset: 0x0018AFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180234, XrefRangeEnd = 180235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBloomThreshold(float threshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x0018CE2C File Offset: 0x0018B02C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 180237, RefRangeEnd = 180246, XrefRangeStart = 180235, XrefRangeEnd = 180237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlur(float blurLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blurLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetBlur_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x0018CE6C File Offset: 0x0018B06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180246, XrefRangeEnd = 180249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x00028A02 File Offset: 0x00026C02
		public PostProcessingManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x060054BF RID: 21695 RVA: 0x0018CEA8 File Offset: 0x0018B0A8
		// (set) Token: 0x060054C0 RID: 21696 RVA: 0x00028A0B File Offset: 0x00026C0B
		public unsafe Volume GlobalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GlobalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GlobalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x060054C1 RID: 21697 RVA: 0x0018CED8 File Offset: 0x0018B0D8
		// (set) Token: 0x060054C2 RID: 21698 RVA: 0x00028A2A File Offset: 0x00026C2A
		public unsafe float Vig_DefaultIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity)) = value;
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x060054C3 RID: 21699 RVA: 0x0018CF00 File Offset: 0x0018B100
		// (set) Token: 0x060054C4 RID: 21700 RVA: 0x00028A45 File Offset: 0x00026C45
		public unsafe float Vig_DefaultSmoothness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness)) = value;
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x060054C5 RID: 21701 RVA: 0x0018CF28 File Offset: 0x0018B128
		// (set) Token: 0x060054C6 RID: 21702 RVA: 0x00028A60 File Offset: 0x00026C60
		public unsafe float MinBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MinBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MinBlur)) = value;
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x060054C7 RID: 21703 RVA: 0x0018CF50 File Offset: 0x0018B150
		// (set) Token: 0x060054C8 RID: 21704 RVA: 0x00028A7B File Offset: 0x00026C7B
		public unsafe float MaxBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MaxBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MaxBlur)) = value;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x060054C9 RID: 21705 RVA: 0x0018CF78 File Offset: 0x0018B178
		// (set) Token: 0x060054CA RID: 21706 RVA: 0x00028A96 File Offset: 0x00026C96
		public unsafe FloatSmoother ChromaticAberrationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x060054CB RID: 21707 RVA: 0x0018CFA8 File Offset: 0x0018B1A8
		// (set) Token: 0x060054CC RID: 21708 RVA: 0x00028AB5 File Offset: 0x00026CB5
		public unsafe FloatSmoother SaturationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_SaturationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_SaturationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x060054CD RID: 21709 RVA: 0x0018CFD8 File Offset: 0x0018B1D8
		// (set) Token: 0x060054CE RID: 21710 RVA: 0x00028AD4 File Offset: 0x00026CD4
		public unsafe FloatSmoother BloomController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x060054CF RID: 21711 RVA: 0x0018D008 File Offset: 0x0018B208
		// (set) Token: 0x060054D0 RID: 21712 RVA: 0x00028AF3 File Offset: 0x00026CF3
		public unsafe HDRColorSmoother ColorFilterController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorFilterController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDRColorSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorFilterController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x060054D1 RID: 21713 RVA: 0x0018D038 File Offset: 0x0018B238
		// (set) Token: 0x060054D2 RID: 21714 RVA: 0x00028B12 File Offset: 0x00026D12
		public unsafe Vignette vig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_vig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vignette>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_vig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x060054D3 RID: 21715 RVA: 0x0018D068 File Offset: 0x0018B268
		// (set) Token: 0x060054D4 RID: 21716 RVA: 0x00028B31 File Offset: 0x00026D31
		public unsafe DepthOfField DoF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_DoF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_DoF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x060054D5 RID: 21717 RVA: 0x0018D098 File Offset: 0x0018B298
		// (set) Token: 0x060054D6 RID: 21718 RVA: 0x00028B50 File Offset: 0x00026D50
		public unsafe GodRaysVolume GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GodRays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GodRaysVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GodRays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x060054D7 RID: 21719 RVA: 0x0018D0C8 File Offset: 0x0018B2C8
		// (set) Token: 0x060054D8 RID: 21720 RVA: 0x00028B6F File Offset: 0x00026D6F
		public unsafe ColorAdjustments ColorAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x060054D9 RID: 21721 RVA: 0x0018D0F8 File Offset: 0x0018B2F8
		// (set) Token: 0x060054DA RID: 21722 RVA: 0x00028B8E File Offset: 0x00026D8E
		public unsafe Beautify beautifySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_beautifySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beautify>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_beautifySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x060054DB RID: 21723 RVA: 0x0018D128 File Offset: 0x0018B328
		// (set) Token: 0x060054DC RID: 21724 RVA: 0x00028BAD File Offset: 0x00026DAD
		public unsafe Bloom bloom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_bloom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bloom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_bloom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x0018D158 File Offset: 0x0018B358
		// (set) Token: 0x060054DE RID: 21726 RVA: 0x00028BCC File Offset: 0x00026DCC
		public unsafe ChromaticAberration chromaticAberration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_chromaticAberration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChromaticAberration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_chromaticAberration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x060054DF RID: 21727 RVA: 0x0018D188 File Offset: 0x0018B388
		// (set) Token: 0x060054E0 RID: 21728 RVA: 0x00028BEB File Offset: 0x00026DEB
		public unsafe ColorAdjustments colorAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_colorAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_colorAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003955 RID: 14677
		private static readonly IntPtr NativeFieldInfoPtr_GlobalVolume;

		// Token: 0x04003956 RID: 14678
		private static readonly IntPtr NativeFieldInfoPtr_Vig_DefaultIntensity;

		// Token: 0x04003957 RID: 14679
		private static readonly IntPtr NativeFieldInfoPtr_Vig_DefaultSmoothness;

		// Token: 0x04003958 RID: 14680
		private static readonly IntPtr NativeFieldInfoPtr_MinBlur;

		// Token: 0x04003959 RID: 14681
		private static readonly IntPtr NativeFieldInfoPtr_MaxBlur;

		// Token: 0x0400395A RID: 14682
		private static readonly IntPtr NativeFieldInfoPtr_ChromaticAberrationController;

		// Token: 0x0400395B RID: 14683
		private static readonly IntPtr NativeFieldInfoPtr_SaturationController;

		// Token: 0x0400395C RID: 14684
		private static readonly IntPtr NativeFieldInfoPtr_BloomController;

		// Token: 0x0400395D RID: 14685
		private static readonly IntPtr NativeFieldInfoPtr_ColorFilterController;

		// Token: 0x0400395E RID: 14686
		private static readonly IntPtr NativeFieldInfoPtr_vig;

		// Token: 0x0400395F RID: 14687
		private static readonly IntPtr NativeFieldInfoPtr_DoF;

		// Token: 0x04003960 RID: 14688
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x04003961 RID: 14689
		private static readonly IntPtr NativeFieldInfoPtr_ColorAdjustments;

		// Token: 0x04003962 RID: 14690
		private static readonly IntPtr NativeFieldInfoPtr_beautifySettings;

		// Token: 0x04003963 RID: 14691
		private static readonly IntPtr NativeFieldInfoPtr_bloom;

		// Token: 0x04003964 RID: 14692
		private static readonly IntPtr NativeFieldInfoPtr_chromaticAberration;

		// Token: 0x04003965 RID: 14693
		private static readonly IntPtr NativeFieldInfoPtr_colorAdjustments;

		// Token: 0x04003966 RID: 14694
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003967 RID: 14695
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04003968 RID: 14696
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_0;

		// Token: 0x04003969 RID: 14697
		private static readonly IntPtr NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0;

		// Token: 0x0400396A RID: 14698
		private static readonly IntPtr NativeMethodInfoPtr_ResetVignette_Public_Void_0;

		// Token: 0x0400396B RID: 14699
		private static readonly IntPtr NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0;

		// Token: 0x0400396C RID: 14700
		private static readonly IntPtr NativeMethodInfoPtr_SetContrast_Public_Void_Single_0;

		// Token: 0x0400396D RID: 14701
		private static readonly IntPtr NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0;

		// Token: 0x0400396E RID: 14702
		private static readonly IntPtr NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0;

		// Token: 0x0400396F RID: 14703
		private static readonly IntPtr NativeMethodInfoPtr_SetBlur_Public_Void_Single_0;

		// Token: 0x04003970 RID: 14704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
