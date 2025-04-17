using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Lighting;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x0200019F RID: 415
	[Serializable]
	public class Tile : MonoBehaviour
	{
		// Token: 0x0600220F RID: 8719 RVA: 0x000DAF68 File Offset: 0x000D9168
		// Note: this type is marked as 'beforefieldinit'.
		static Tile()
		{
			Il2CppClassPointerStore<Tile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "Tile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tile>.NativeClassPtr);
			Tile.NativeFieldInfoPtr_TileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "TileSize");
			Tile.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "x");
			Tile.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "y");
			Tile.NativeFieldInfoPtr_AvailableOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "AvailableOffset");
			Tile.NativeFieldInfoPtr_OwnerGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "OwnerGrid");
			Tile.NativeFieldInfoPtr_LightExposureNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "LightExposureNode");
			Tile.NativeFieldInfoPtr_BuildableOccupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "BuildableOccupants");
			Tile.NativeFieldInfoPtr_ConstructableOccupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "ConstructableOccupants");
			Tile.NativeFieldInfoPtr_OccupantTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "OccupantTiles");
			Tile.NativeFieldInfoPtr_onTileChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "onTileChanged");
			Tile.NativeMethodInfoPtr_InitializePropertyTile_Public_Void_Int32_Int32_Single_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667142);
			Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_GridItem_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667143);
			Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_Constructable_GridBased_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667144);
			Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_GridItem_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667145);
			Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_Constructable_GridBased_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667146);
			Tile.NativeMethodInfoPtr_CanBeBuiltOn_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667147);
			Tile.NativeMethodInfoPtr_GetSurroundingTiles_Public_List_1_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667148);
			Tile.NativeMethodInfoPtr_IsIndoorTile_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667149);
			Tile.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667150);
			Tile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667151);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000DB128 File Offset: 0x000D9328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111110, XrefRangeEnd = 111111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializePropertyTile(int _x, int _y, float _available_Offset, Grid _ownerGrid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _available_Offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_ownerGrid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_InitializePropertyTile_Public_Void_Int32_Int32_Single_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000DB198 File Offset: 0x000D9398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111111, XrefRangeEnd = 111127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOccupant(GridItem occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_GridItem_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x000DB1EC File Offset: 0x000D93EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111127, XrefRangeEnd = 111143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_Constructable_GridBased_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x000DB240 File Offset: 0x000D9440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111149, RefRangeEnd = 111151, XrefRangeStart = 111143, XrefRangeEnd = 111149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOccupant(GridItem occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_GridItem_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x000DB294 File Offset: 0x000D9494
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111157, RefRangeEnd = 111159, XrefRangeStart = 111151, XrefRangeEnd = 111157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_Constructable_GridBased_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x000DB2E8 File Offset: 0x000D94E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111159, XrefRangeEnd = 111168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeBuiltOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tile.NativeMethodInfoPtr_CanBeBuiltOn_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x000DB330 File Offset: 0x000D9530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111192, RefRangeEnd = 111193, XrefRangeStart = 111168, XrefRangeEnd = 111192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tile> GetSurroundingTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_GetSurroundingTiles_Public_List_1_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr3) : null;
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x000DB370 File Offset: 0x000D9570
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsIndoorTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tile.NativeMethodInfoPtr_IsIndoorTile_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x000DB3B8 File Offset: 0x000D95B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111193, XrefRangeEnd = 111202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x000DB3F8 File Offset: 0x000D95F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111202, XrefRangeEnd = 111224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00012FF3 File Offset: 0x000111F3
		public Tile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x000DB434 File Offset: 0x000D9634
		// (set) Token: 0x0600221C RID: 8732 RVA: 0x00012FFC File Offset: 0x000111FC
		public unsafe static float TileSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Tile.NativeFieldInfoPtr_TileSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tile.NativeFieldInfoPtr_TileSize, (void*)(&value));
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x000DB450 File Offset: 0x000D9650
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x0001300A File Offset: 0x0001120A
		public unsafe int x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x000DB478 File Offset: 0x000D9678
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x00013025 File Offset: 0x00011225
		public unsafe int y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x000DB4A0 File Offset: 0x000D96A0
		// (set) Token: 0x06002222 RID: 8738 RVA: 0x00013040 File Offset: 0x00011240
		public unsafe float AvailableOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_AvailableOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_AvailableOffset)) = value;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x000DB4C8 File Offset: 0x000D96C8
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x0001305B File Offset: 0x0001125B
		public unsafe Grid OwnerGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OwnerGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OwnerGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x000DB4F8 File Offset: 0x000D96F8
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x0001307A File Offset: 0x0001127A
		public unsafe LightExposureNode LightExposureNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_LightExposureNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightExposureNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_LightExposureNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x000DB528 File Offset: 0x000D9728
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x00013099 File Offset: 0x00011299
		public unsafe List<GridItem> BuildableOccupants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_BuildableOccupants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GridItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_BuildableOccupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x000DB558 File Offset: 0x000D9758
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x000130B8 File Offset: 0x000112B8
		public unsafe List<Constructable_GridBased> ConstructableOccupants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_ConstructableOccupants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Constructable_GridBased>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_ConstructableOccupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x000DB588 File Offset: 0x000D9788
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x000130D7 File Offset: 0x000112D7
		public unsafe List<FootprintTile> OccupantTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OccupantTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootprintTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OccupantTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x000DB5B8 File Offset: 0x000D97B8
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x000130F6 File Offset: 0x000112F6
		public unsafe Tile.TileChange onTileChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_onTileChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile.TileChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_onTileChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeFieldInfoPtr_TileSize;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeFieldInfoPtr_AvailableOffset;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeFieldInfoPtr_OwnerGrid;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeFieldInfoPtr_LightExposureNode;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeFieldInfoPtr_BuildableOccupants;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeFieldInfoPtr_ConstructableOccupants;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeFieldInfoPtr_OccupantTiles;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeFieldInfoPtr_onTileChanged;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_InitializePropertyTile_Public_Void_Int32_Int32_Single_Grid_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_AddOccupant_Public_Void_GridItem_FootprintTile_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_AddOccupant_Public_Void_Constructable_GridBased_FootprintTile_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Void_GridItem_FootprintTile_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Void_Constructable_GridBased_FootprintTile_0;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBuiltOn_Public_Virtual_New_Boolean_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingTiles_Public_List_1_Tile_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_IsIndoorTile_Public_Virtual_New_Boolean_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008C1 RID: 2241
		public sealed class TileChange : MulticastDelegate
		{
			// Token: 0x0600C395 RID: 50069 RVA: 0x002FB034 File Offset: 0x002F9234
			// Note: this type is marked as 'beforefieldinit'.
			static TileChange()
			{
				Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tile>.NativeClassPtr, "TileChange");
				Tile.TileChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100667153);
				Tile.TileChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100667154);
				Tile.TileChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Tile_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100667155);
				Tile.TileChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100667156);
			}

			// Token: 0x0600C396 RID: 50070 RVA: 0x002FB0A8 File Offset: 0x002F92A8
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 106407, RefRangeEnd = 106486, XrefRangeStart = 106407, XrefRangeEnd = 106486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TileChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C397 RID: 50071 RVA: 0x002FB104 File Offset: 0x002F9304
			[CallerCount(0)]
			public unsafe void Invoke(Tile thisTile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisTile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C398 RID: 50072 RVA: 0x002FB148 File Offset: 0x002F9348
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Tile thisTile, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisTile);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Tile_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C399 RID: 50073 RVA: 0x002FB1BC File Offset: 0x002F93BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C39A RID: 50074 RVA: 0x0005F380 File Offset: 0x0005D580
			public TileChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C39B RID: 50075 RVA: 0x0005F389 File Offset: 0x0005D589
			public static implicit operator Tile.TileChange(Action<Tile> A_0)
			{
				return DelegateSupport.ConvertDelegate<Tile.TileChange>(A_0);
			}

			// Token: 0x0600C39C RID: 50076 RVA: 0x0005F391 File Offset: 0x0005D591
			public static Tile.TileChange operator +(Tile.TileChange A_0, Tile.TileChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Tile.TileChange>();
			}

			// Token: 0x0600C39D RID: 50077 RVA: 0x0005F39F File Offset: 0x0005D59F
			public static Tile.TileChange operator -(Tile.TileChange A_0, Tile.TileChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Tile.TileChange>();
				}
				return result;
			}

			// Token: 0x0400849B RID: 33947
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400849C RID: 33948
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Tile_0;

			// Token: 0x0400849D RID: 33949
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Tile_AsyncCallback_Object_0;

			// Token: 0x0400849E RID: 33950
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
