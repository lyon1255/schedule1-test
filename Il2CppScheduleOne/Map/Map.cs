using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Levelling;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077B RID: 1915
	public class Map : Singleton<Map>
	{
		// Token: 0x0600B57A RID: 46458 RVA: 0x002D1D18 File Offset: 0x002CFF18
		// Note: this type is marked as 'beforefieldinit'.
		static Map()
		{
			Il2CppClassPointerStore<Map>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Map");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map>.NativeClassPtr);
			Map.NativeFieldInfoPtr_Regions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "Regions");
			Map.NativeFieldInfoPtr_PoliceStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "PoliceStation");
			Map.NativeFieldInfoPtr_MedicalCentre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "MedicalCentre");
			Map.NativeFieldInfoPtr_TreeBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "TreeBounds");
			Map.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685600);
			Map.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685601);
			Map.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685602);
			Map.NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685603);
			Map.NativeMethodInfoPtr_GameLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685604);
			Map.NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685605);
			Map.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685606);
		}

		// Token: 0x0600B57B RID: 46459 RVA: 0x002D1E24 File Offset: 0x002D0024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309952, XrefRangeEnd = 310012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57C RID: 46460 RVA: 0x002D1E60 File Offset: 0x002D0060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310012, XrefRangeEnd = 310046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57D RID: 46461 RVA: 0x002D1E9C File Offset: 0x002D009C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310046, XrefRangeEnd = 310064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57E RID: 46462 RVA: 0x002D1ED8 File Offset: 0x002D00D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 310078, RefRangeEnd = 310084, XrefRangeStart = 310064, XrefRangeEnd = 310078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapRegionData GetRegionData(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MapRegionData>(intPtr3) : null;
		}

		// Token: 0x0600B57F RID: 46463 RVA: 0x002D1F24 File Offset: 0x002D0124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310084, XrefRangeEnd = 310095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_GameLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B580 RID: 46464 RVA: 0x002D1F58 File Offset: 0x002D0158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310095, XrefRangeEnd = 310106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRankUp(FullRank oldRank, FullRank newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B581 RID: 46465 RVA: 0x002D1FA4 File Offset: 0x002D01A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310106, XrefRangeEnd = 310109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Map() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B582 RID: 46466 RVA: 0x00059140 File Offset: 0x00057340
		public Map(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600B583 RID: 46467 RVA: 0x002D1FE0 File Offset: 0x002D01E0
		// (set) Token: 0x0600B584 RID: 46468 RVA: 0x00059149 File Offset: 0x00057349
		public unsafe Il2CppReferenceArray<MapRegionData> Regions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_Regions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapRegionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_Regions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600B585 RID: 46469 RVA: 0x002D2010 File Offset: 0x002D0210
		// (set) Token: 0x0600B586 RID: 46470 RVA: 0x00059168 File Offset: 0x00057368
		public unsafe PoliceStation PoliceStation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_PoliceStation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_PoliceStation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600B587 RID: 46471 RVA: 0x002D2040 File Offset: 0x002D0240
		// (set) Token: 0x0600B588 RID: 46472 RVA: 0x00059187 File Offset: 0x00057387
		public unsafe MedicalCentre MedicalCentre
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_MedicalCentre);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MedicalCentre>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_MedicalCentre), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600B589 RID: 46473 RVA: 0x002D2070 File Offset: 0x002D0270
		// (set) Token: 0x0600B58A RID: 46474 RVA: 0x000591A6 File Offset: 0x000573A6
		public unsafe Transform TreeBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_TreeBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_TreeBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A4B RID: 31307
		private static readonly IntPtr NativeFieldInfoPtr_Regions;

		// Token: 0x04007A4C RID: 31308
		private static readonly IntPtr NativeFieldInfoPtr_PoliceStation;

		// Token: 0x04007A4D RID: 31309
		private static readonly IntPtr NativeFieldInfoPtr_MedicalCentre;

		// Token: 0x04007A4E RID: 31310
		private static readonly IntPtr NativeFieldInfoPtr_TreeBounds;

		// Token: 0x04007A4F RID: 31311
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007A50 RID: 31312
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007A51 RID: 31313
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04007A52 RID: 31314
		private static readonly IntPtr NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0;

		// Token: 0x04007A53 RID: 31315
		private static readonly IntPtr NativeMethodInfoPtr_GameLoaded_Private_Void_0;

		// Token: 0x04007A54 RID: 31316
		private static readonly IntPtr NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0;

		// Token: 0x04007A55 RID: 31317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFB RID: 3067
		[ObfuscatedName("ScheduleOne.Map.Map+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFC8 RID: 57288 RVA: 0x0034B618 File Offset: 0x00349818
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Map>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr);
				Map.__c__DisplayClass4_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr, "region");
				Map.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr, 100685607);
				Map.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr, 100685608);
			}

			// Token: 0x0600DFC9 RID: 57289 RVA: 0x0034B680 File Offset: 0x00349880
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFCA RID: 57290 RVA: 0x0034B6BC File Offset: 0x003498BC
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(MapRegionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFCB RID: 57291 RVA: 0x0006D1F5 File Offset: 0x0006B3F5
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004559 RID: 17753
			// (get) Token: 0x0600DFCC RID: 57292 RVA: 0x0034B70C File Offset: 0x0034990C
			// (set) Token: 0x0600DFCD RID: 57293 RVA: 0x0006D1FE File Offset: 0x0006B3FE
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass4_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass4_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x040095DF RID: 38367
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x040095E0 RID: 38368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095E1 RID: 38369
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0;
		}

		// Token: 0x02000BFC RID: 3068
		[ObfuscatedName("ScheduleOne.Map.Map+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFCE RID: 57294 RVA: 0x0034B734 File Offset: 0x00349934
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Map>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr);
				Map.__c__DisplayClass7_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr, "region");
				Map.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr, 100685609);
				Map.__c__DisplayClass7_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr, 100685610);
			}

			// Token: 0x0600DFCF RID: 57295 RVA: 0x0034B79C File Offset: 0x0034999C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFD0 RID: 57296 RVA: 0x0034B7D8 File Offset: 0x003499D8
			[CallerCount(0)]
			public unsafe bool _GetRegionData_b__0(MapRegionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass7_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFD1 RID: 57297 RVA: 0x0006D219 File Offset: 0x0006B419
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455A RID: 17754
			// (get) Token: 0x0600DFD2 RID: 57298 RVA: 0x0034B828 File Offset: 0x00349A28
			// (set) Token: 0x0600DFD3 RID: 57299 RVA: 0x0006D222 File Offset: 0x0006B422
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass7_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass7_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x040095E2 RID: 38370
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x040095E3 RID: 38371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095E4 RID: 38372
			private static readonly IntPtr NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0;
		}
	}
}
