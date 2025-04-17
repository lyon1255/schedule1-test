using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000777 RID: 1911
	[Serializable]
	public class MapRegionData : Il2CppSystem.Object
	{
		// Token: 0x0600B51C RID: 46364 RVA: 0x002D0DC8 File Offset: 0x002CEFC8
		// Note: this type is marked as 'beforefieldinit'.
		static MapRegionData()
		{
			Il2CppClassPointerStore<MapRegionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MapRegionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr);
			MapRegionData.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "Region");
			MapRegionData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "Name");
			MapRegionData.NativeFieldInfoPtr_RankRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RankRequirement");
			MapRegionData.NativeFieldInfoPtr_StartingNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "StartingNPCs");
			MapRegionData.NativeFieldInfoPtr_RegionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionSprite");
			MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionDeliveryLocations");
			MapRegionData.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100685575);
			MapRegionData.NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100685576);
			MapRegionData.NativeMethodInfoPtr_SetUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100685577);
			MapRegionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100685578);
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0600B51D RID: 46365 RVA: 0x002D0EC0 File Offset: 0x002CF0C0
		public unsafe bool IsUnlocked
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 309819, RefRangeEnd = 309823, XrefRangeStart = 309815, XrefRangeEnd = 309819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B51E RID: 46366 RVA: 0x002D0EFC File Offset: 0x002CF0FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309852, RefRangeEnd = 309853, XrefRangeStart = 309823, XrefRangeEnd = 309852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr3) : null;
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x002D0F3C File Offset: 0x002CF13C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309854, RefRangeEnd = 309856, XrefRangeStart = 309853, XrefRangeEnd = 309854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_SetUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x002D0F70 File Offset: 0x002CF170
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapRegionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x00058D92 File Offset: 0x00056F92
		public MapRegionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x0600B522 RID: 46370 RVA: 0x002D0FAC File Offset: 0x002CF1AC
		// (set) Token: 0x0600B523 RID: 46371 RVA: 0x00058D9B File Offset: 0x00056F9B
		public unsafe EMapRegion Region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Region)) = value;
			}
		}

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0600B524 RID: 46372 RVA: 0x002D0FD4 File Offset: 0x002CF1D4
		// (set) Token: 0x0600B525 RID: 46373 RVA: 0x00058DB6 File Offset: 0x00056FB6
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0600B526 RID: 46374 RVA: 0x002D0FFC File Offset: 0x002CF1FC
		// (set) Token: 0x0600B527 RID: 46375 RVA: 0x00058DD5 File Offset: 0x00056FD5
		public unsafe FullRank RankRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RankRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RankRequirement)) = value;
			}
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0600B528 RID: 46376 RVA: 0x002D1024 File Offset: 0x002CF224
		// (set) Token: 0x0600B529 RID: 46377 RVA: 0x00058DF0 File Offset: 0x00056FF0
		public unsafe Il2CppReferenceArray<NPC> StartingNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_StartingNPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_StartingNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0600B52A RID: 46378 RVA: 0x002D1054 File Offset: 0x002CF254
		// (set) Token: 0x0600B52B RID: 46379 RVA: 0x00058E0F File Offset: 0x0005700F
		public unsafe Sprite RegionSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0600B52C RID: 46380 RVA: 0x002D1084 File Offset: 0x002CF284
		// (set) Token: 0x0600B52D RID: 46381 RVA: 0x00058E2E File Offset: 0x0005702E
		public unsafe Il2CppReferenceArray<DeliveryLocation> RegionDeliveryLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryLocation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A15 RID: 31253
		private static readonly IntPtr NativeFieldInfoPtr_Region;

		// Token: 0x04007A16 RID: 31254
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04007A17 RID: 31255
		private static readonly IntPtr NativeFieldInfoPtr_RankRequirement;

		// Token: 0x04007A18 RID: 31256
		private static readonly IntPtr NativeFieldInfoPtr_StartingNPCs;

		// Token: 0x04007A19 RID: 31257
		private static readonly IntPtr NativeFieldInfoPtr_RegionSprite;

		// Token: 0x04007A1A RID: 31258
		private static readonly IntPtr NativeFieldInfoPtr_RegionDeliveryLocations;

		// Token: 0x04007A1B RID: 31259
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0;

		// Token: 0x04007A1C RID: 31260
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0;

		// Token: 0x04007A1D RID: 31261
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_0;

		// Token: 0x04007A1E RID: 31262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFA RID: 3066
		[ObfuscatedName("ScheduleOne.Map.MapRegionData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DFC0 RID: 57280 RVA: 0x0034B4C0 File Offset: 0x003496C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr);
				MapRegionData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, "<>9");
				MapRegionData.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, "<>9__8_0");
				MapRegionData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, 100685580);
				MapRegionData.__c.NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__8_0_Internal_Boolean_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, 100685581);
			}

			// Token: 0x0600DFC1 RID: 57281 RVA: 0x0034B53C File Offset: 0x0034973C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFC2 RID: 57282 RVA: 0x0034B578 File Offset: 0x00349778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309814, XrefRangeEnd = 309815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomUnscheduledDeliveryLocation_b__8_0(DeliveryLocation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.__c.NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__8_0_Internal_Boolean_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFC3 RID: 57283 RVA: 0x0006D1C8 File Offset: 0x0006B3C8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004557 RID: 17751
			// (get) Token: 0x0600DFC4 RID: 57284 RVA: 0x0034B5C8 File Offset: 0x003497C8
			// (set) Token: 0x0600DFC5 RID: 57285 RVA: 0x0006D1D1 File Offset: 0x0006B3D1
			public unsafe static MapRegionData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MapRegionData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapRegionData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MapRegionData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004558 RID: 17752
			// (get) Token: 0x0600DFC6 RID: 57286 RVA: 0x0034B5F0 File Offset: 0x003497F0
			// (set) Token: 0x0600DFC7 RID: 57287 RVA: 0x0006D1E3 File Offset: 0x0006B3E3
			public unsafe static Func<DeliveryLocation, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MapRegionData.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeliveryLocation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MapRegionData.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095DB RID: 38363
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040095DC RID: 38364
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040095DD RID: 38365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095DE RID: 38366
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__8_0_Internal_Boolean_DeliveryLocation_0;
		}
	}
}
