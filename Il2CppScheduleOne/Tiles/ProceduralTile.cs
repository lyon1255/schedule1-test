using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x0200019E RID: 414
	public class ProceduralTile : MonoBehaviour
	{
		// Token: 0x060021FF RID: 8703 RVA: 0x000DAC7C File Offset: 0x000D8E7C
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralTile()
		{
			Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "ProceduralTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr);
			ProceduralTile.NativeFieldInfoPtr_TileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "TileType");
			ProceduralTile.NativeFieldInfoPtr_ParentBuildableItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "ParentBuildableItem");
			ProceduralTile.NativeFieldInfoPtr_MatchedFootprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "MatchedFootprintTile");
			ProceduralTile.NativeFieldInfoPtr_Occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "Occupants");
			ProceduralTile.NativeFieldInfoPtr_OccupantTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "OccupantTiles");
			ProceduralTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100667138);
			ProceduralTile.NativeMethodInfoPtr_AddOccupant_Public_Void_FootprintTile_ProceduralGridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100667139);
			ProceduralTile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_FootprintTile_ProceduralGridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100667140);
			ProceduralTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100667141);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x000DAD60 File Offset: 0x000D8F60
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x000DAD9C File Offset: 0x000D8F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111080, RefRangeEnd = 111081, XrefRangeStart = 111066, XrefRangeEnd = 111080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprint);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralTile.NativeMethodInfoPtr_AddOccupant_Public_Void_FootprintTile_ProceduralGridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x000DADF0 File Offset: 0x000D8FF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111093, RefRangeEnd = 111095, XrefRangeStart = 111081, XrefRangeEnd = 111093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprint);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralTile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_FootprintTile_ProceduralGridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000DAE44 File Offset: 0x000D9044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111095, XrefRangeEnd = 111110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00012F53 File Offset: 0x00011153
		public ProceduralTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x000DAE80 File Offset: 0x000D9080
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x00012F5C File Offset: 0x0001115C
		public unsafe ProceduralTile.EProceduralTileType TileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_TileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_TileType)) = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000DAEA8 File Offset: 0x000D90A8
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x00012F77 File Offset: 0x00011177
		public unsafe BuildableItem ParentBuildableItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_ParentBuildableItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_ParentBuildableItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000DAED8 File Offset: 0x000D90D8
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x00012F96 File Offset: 0x00011196
		public unsafe FootprintTile MatchedFootprintTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_MatchedFootprintTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_MatchedFootprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x000DAF08 File Offset: 0x000D9108
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x00012FB5 File Offset: 0x000111B5
		public unsafe List<ProceduralGridItem> Occupants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_Occupants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralGridItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_Occupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x000DAF38 File Offset: 0x000D9138
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x00012FD4 File Offset: 0x000111D4
		public unsafe List<FootprintTile> OccupantTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_OccupantTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootprintTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_OccupantTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeFieldInfoPtr_TileType;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeFieldInfoPtr_ParentBuildableItem;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeFieldInfoPtr_MatchedFootprintTile;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeFieldInfoPtr_Occupants;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeFieldInfoPtr_OccupantTiles;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_AddOccupant_Public_Void_FootprintTile_ProceduralGridItem_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Void_FootprintTile_ProceduralGridItem_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008C0 RID: 2240
		[OriginalName("Assembly-CSharp.dll", "", "EProceduralTileType")]
		public enum EProceduralTileType
		{
			// Token: 0x0400849A RID: 33946
			Rack
		}
	}
}
