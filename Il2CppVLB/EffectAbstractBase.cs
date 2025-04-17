using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000080 RID: 128
	public class EffectAbstractBase : MonoBehaviour
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x0008CDD4 File Offset: 0x0008AFD4
		// Note: this type is marked as 'beforefieldinit'.
		static EffectAbstractBase()
		{
			Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr);
			EffectAbstractBase.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "ClassName");
			EffectAbstractBase.NativeFieldInfoPtr_componentsToChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "componentsToChange");
			EffectAbstractBase.NativeFieldInfoPtr_restoreIntensityOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "restoreIntensityOnDisable");
			EffectAbstractBase.NativeFieldInfoPtr_m_Beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_Beam");
			EffectAbstractBase.NativeFieldInfoPtr_m_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_Light");
			EffectAbstractBase.NativeFieldInfoPtr_m_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_Particles");
			EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_BaseIntensityBeamInside");
			EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_BaseIntensityBeamOutside");
			EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_BaseIntensityLight");
			EffectAbstractBase.NativeMethodInfoPtr_get_restoreBaseIntensity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664283);
			EffectAbstractBase.NativeMethodInfoPtr_set_restoreBaseIntensity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664284);
			EffectAbstractBase.NativeMethodInfoPtr_InitFrom_Public_Virtual_New_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664285);
			EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664286);
			EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664287);
			EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamSD_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664288);
			EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamHD_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664289);
			EffectAbstractBase.NativeMethodInfoPtr_SetAdditiveIntensity_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664290);
			EffectAbstractBase.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664291);
			EffectAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664292);
			EffectAbstractBase.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664293);
			EffectAbstractBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664294);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0008CFA8 File Offset: 0x0008B1A8
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x0008CFE4 File Offset: 0x0008B1E4
		public unsafe bool restoreBaseIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_get_restoreBaseIntensity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_set_restoreBaseIntensity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0008D024 File Offset: 0x0008B224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80043, XrefRangeEnd = 80047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitFrom(EffectAbstractBase Source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectAbstractBase.NativeMethodInfoPtr_InitFrom_Public_Virtual_New_Void_EffectAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0008D074 File Offset: 0x0008B274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80047, XrefRangeEnd = 80051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIntensity(VolumetricLightBeamSD beam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamSD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0008D0B8 File Offset: 0x0008B2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80051, XrefRangeEnd = 80055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIntensity(VolumetricLightBeamHD beam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0008D0FC File Offset: 0x0008B2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80055, XrefRangeEnd = 80059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntensity(VolumetricLightBeamSD beam, float additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamSD_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0008D14C File Offset: 0x0008B34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80059, XrefRangeEnd = 80064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntensity(VolumetricLightBeamHD beam, float additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamHD_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0008D19C File Offset: 0x0008B39C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80092, RefRangeEnd = 80095, XrefRangeStart = 80064, XrefRangeEnd = 80092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdditiveIntensity(float additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref additive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_SetAdditiveIntensity_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0008D1DC File Offset: 0x0008B3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80095, XrefRangeEnd = 80128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0008D210 File Offset: 0x0008B410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80128, XrefRangeEnd = 80129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0008D24C File Offset: 0x0008B44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80129, XrefRangeEnd = 80131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0008D280 File Offset: 0x0008B480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80131, XrefRangeEnd = 80132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0000703E File Offset: 0x0000523E
		public EffectAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0008D2BC File Offset: 0x0008B4BC
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x00007047 File Offset: 0x00005247
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectAbstractBase.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectAbstractBase.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0008D2DC File Offset: 0x0008B4DC
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00007059 File Offset: 0x00005259
		public unsafe EffectAbstractBase.ComponentsToChange componentsToChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_componentsToChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_componentsToChange)) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0008D304 File Offset: 0x0008B504
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00007074 File Offset: 0x00005274
		public unsafe bool restoreIntensityOnDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_restoreIntensityOnDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_restoreIntensityOnDisable)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0008D32C File Offset: 0x0008B52C
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x0000708F File Offset: 0x0000528F
		public unsafe VolumetricLightBeamAbstractBase m_Beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0008D35C File Offset: 0x0008B55C
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x000070AE File Offset: 0x000052AE
		public unsafe Light m_Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0008D38C File Offset: 0x0008B58C
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x000070CD File Offset: 0x000052CD
		public unsafe VolumetricDustParticles m_Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricDustParticles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0008D3BC File Offset: 0x0008B5BC
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x000070EC File Offset: 0x000052EC
		public unsafe float m_BaseIntensityBeamInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamInside)) = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0008D3E4 File Offset: 0x0008B5E4
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00007107 File Offset: 0x00005307
		public unsafe float m_BaseIntensityBeamOutside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamOutside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamOutside)) = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0008D40C File Offset: 0x0008B60C
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00007122 File Offset: 0x00005322
		public unsafe float m_BaseIntensityLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityLight)) = value;
			}
		}

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_componentsToChange;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr_restoreIntensityOnDisable;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_m_Beam;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_m_Light;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_m_Particles;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIntensityBeamInside;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIntensityBeamOutside;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIntensityLight;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreBaseIntensity_Public_get_Boolean_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_set_restoreBaseIntensity_Public_set_Void_Boolean_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_InitFrom_Public_Virtual_New_Void_EffectAbstractBase_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamSD_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamHD_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamSD_Single_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamHD_Single_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditiveIntensity_Protected_Void_Single_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000816 RID: 2070
		[OriginalName("Assembly-CSharp.dll", "", "ComponentsToChange")]
		[Flags]
		public enum ComponentsToChange
		{
			// Token: 0x0400809A RID: 32922
			UnityLight = 1,
			// Token: 0x0400809B RID: 32923
			VolumetricLightBeam = 2,
			// Token: 0x0400809C RID: 32924
			VolumetricDustParticles = 4
		}
	}
}
