using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BD RID: 1213
	public class BuildUpdate_Grid : BuildUpdate_Base
	{
		// Token: 0x06006A22 RID: 27170 RVA: 0x001DAA84 File Offset: 0x001D8C84
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Grid()
		{
			Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Grid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr);
			BuildUpdate_Grid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "GhostModel");
			BuildUpdate_Grid.NativeFieldInfoPtr_BuildableItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "BuildableItemClass");
			BuildUpdate_Grid.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "ItemInstance");
			BuildUpdate_Grid.NativeFieldInfoPtr_CurrentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "CurrentRotation");
			BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "detectionRange");
			BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "detectionMask");
			BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "rotation_Smoothing");
			BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "AllowRotation");
			BuildUpdate_Grid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "validPosition");
			BuildUpdate_Grid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_Grid.NativeFieldInfoPtr_closestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "closestIntersection");
			BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "verticalOffset");
			BuildUpdate_Grid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676778);
			BuildUpdate_Grid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676779);
			BuildUpdate_Grid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676780);
			BuildUpdate_Grid.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676781);
			BuildUpdate_Grid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676782);
			BuildUpdate_Grid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676783);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676784);
			BuildUpdate_Grid.NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676785);
			BuildUpdate_Grid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676786);
			BuildUpdate_Grid.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676787);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676788);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676789);
			BuildUpdate_Grid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676790);
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x001DACA8 File Offset: 0x001D8EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213811, XrefRangeEnd = 213843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x001DACE4 File Offset: 0x001D8EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213843, XrefRangeEnd = 213861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x001DAD20 File Offset: 0x001D8F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213861, XrefRangeEnd = 213971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x001DAD5C File Offset: 0x001D8F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214000, RefRangeEnd = 214001, XrefRangeStart = 213971, XrefRangeEnd = 214000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward, bool buildPointAsOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dist;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitizeForward;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buildPointAsOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x001DADB8 File Offset: 0x001D8FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214001, XrefRangeEnd = 214014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x001DADEC File Offset: 0x001D8FEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214045, RefRangeEnd = 214047, XrefRangeStart = 214014, XrefRangeEnd = 214045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x001DAE20 File Offset: 0x001D9020
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214077, RefRangeEnd = 214080, XrefRangeStart = 214047, XrefRangeEnd = 214077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<TileIntersection> GetRelevantIntersections(FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TileIntersection>>(intPtr3) : null;
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x001DAE70 File Offset: 0x001D9070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214080, XrefRangeEnd = 214218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x001DAEAC File Offset: 0x001D90AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214234, RefRangeEnd = 214235, XrefRangeStart = 214218, XrefRangeEnd = 214234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x001DAEE0 File Offset: 0x001D90E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214235, XrefRangeEnd = 214271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x001DAF1C File Offset: 0x001D911C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214271, XrefRangeEnd = 214277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A2E RID: 27182 RVA: 0x001DAF58 File Offset: 0x001D9158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214277, XrefRangeEnd = 214292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grid GetHoveredGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr3) : null;
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x001DAF98 File Offset: 0x001D9198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214292, XrefRangeEnd = 214293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Grid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x000321CD File Offset: 0x000303CD
		public BuildUpdate_Grid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06006A31 RID: 27185 RVA: 0x001DAFD4 File Offset: 0x001D91D4
		// (set) Token: 0x06006A32 RID: 27186 RVA: 0x000321D6 File Offset: 0x000303D6
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06006A33 RID: 27187 RVA: 0x001DB004 File Offset: 0x001D9204
		// (set) Token: 0x06006A34 RID: 27188 RVA: 0x000321F5 File Offset: 0x000303F5
		public unsafe GridItem BuildableItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_BuildableItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_BuildableItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06006A35 RID: 27189 RVA: 0x001DB034 File Offset: 0x001D9234
		// (set) Token: 0x06006A36 RID: 27190 RVA: 0x00032214 File Offset: 0x00030414
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06006A37 RID: 27191 RVA: 0x001DB064 File Offset: 0x001D9264
		// (set) Token: 0x06006A38 RID: 27192 RVA: 0x00032233 File Offset: 0x00030433
		public unsafe float CurrentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_CurrentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_CurrentRotation)) = value;
			}
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06006A39 RID: 27193 RVA: 0x001DB08C File Offset: 0x001D928C
		// (set) Token: 0x06006A3A RID: 27194 RVA: 0x0003224E File Offset: 0x0003044E
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x06006A3B RID: 27195 RVA: 0x001DB0B4 File Offset: 0x001D92B4
		// (set) Token: 0x06006A3C RID: 27196 RVA: 0x00032269 File Offset: 0x00030469
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x06006A3D RID: 27197 RVA: 0x001DB0DC File Offset: 0x001D92DC
		// (set) Token: 0x06006A3E RID: 27198 RVA: 0x00032284 File Offset: 0x00030484
		public unsafe float rotation_Smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing)) = value;
			}
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06006A3F RID: 27199 RVA: 0x001DB104 File Offset: 0x001D9304
		// (set) Token: 0x06006A40 RID: 27200 RVA: 0x0003229F File Offset: 0x0003049F
		public unsafe bool AllowRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation)) = value;
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06006A41 RID: 27201 RVA: 0x001DB12C File Offset: 0x001D932C
		// (set) Token: 0x06006A42 RID: 27202 RVA: 0x000322BA File Offset: 0x000304BA
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06006A43 RID: 27203 RVA: 0x001DB154 File Offset: 0x001D9354
		// (set) Token: 0x06006A44 RID: 27204 RVA: 0x000322D5 File Offset: 0x000304D5
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06006A45 RID: 27205 RVA: 0x001DB184 File Offset: 0x001D9384
		// (set) Token: 0x06006A46 RID: 27206 RVA: 0x000322F4 File Offset: 0x000304F4
		public unsafe TileIntersection closestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_closestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileIntersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_closestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06006A47 RID: 27207 RVA: 0x001DB1B4 File Offset: 0x001D93B4
		// (set) Token: 0x06006A48 RID: 27208 RVA: 0x00032313 File Offset: 0x00030513
		public unsafe float verticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset)) = value;
			}
		}

		// Token: 0x040048AD RID: 18605
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x040048AE RID: 18606
		private static readonly IntPtr NativeFieldInfoPtr_BuildableItemClass;

		// Token: 0x040048AF RID: 18607
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x040048B0 RID: 18608
		private static readonly IntPtr NativeFieldInfoPtr_CurrentRotation;

		// Token: 0x040048B1 RID: 18609
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x040048B2 RID: 18610
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040048B3 RID: 18611
		private static readonly IntPtr NativeFieldInfoPtr_rotation_Smoothing;

		// Token: 0x040048B4 RID: 18612
		private static readonly IntPtr NativeFieldInfoPtr_AllowRotation;

		// Token: 0x040048B5 RID: 18613
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x040048B6 RID: 18614
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x040048B7 RID: 18615
		private static readonly IntPtr NativeFieldInfoPtr_closestIntersection;

		// Token: 0x040048B8 RID: 18616
		private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

		// Token: 0x040048B9 RID: 18617
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040048BA RID: 18618
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040048BB RID: 18619
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040048BC RID: 18620
		private static readonly IntPtr NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0;

		// Token: 0x040048BD RID: 18621
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x040048BE RID: 18622
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x040048BF RID: 18623
		private static readonly IntPtr NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0;

		// Token: 0x040048C0 RID: 18624
		private static readonly IntPtr NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x040048C1 RID: 18625
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x040048C2 RID: 18626
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x040048C3 RID: 18627
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0;

		// Token: 0x040048C4 RID: 18628
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0;

		// Token: 0x040048C5 RID: 18629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
