using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048C RID: 1164
	public class ConstructUpdate_OutdoorGrid : ConstructUpdate_Base
	{
		// Token: 0x060064AF RID: 25775 RVA: 0x001C7424 File Offset: 0x001C5624
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_OutdoorGrid()
		{
			Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_OutdoorGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr);
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "detectionMask");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_ConstructableClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "ConstructableClass");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "GhostModel");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "validPosition");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "currentRotation");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "currentGhostMaterial");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_closestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "closestIntersection");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_listingPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "listingPrice");
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676055);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676056);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676057);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676058);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676059);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckTileIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676060);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676061);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_AreMetaReqsMet_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676062);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_New_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676063);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_FinalizeMoveConstructable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676064);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676065);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676066);
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x001C75E4 File Offset: 0x001C57E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204421, XrefRangeEnd = 204434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x001C7620 File Offset: 0x001C5820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204434, XrefRangeEnd = 204451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x001C765C File Offset: 0x001C585C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204470, RefRangeEnd = 204471, XrefRangeStart = 204451, XrefRangeEnd = 204470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x001C7698 File Offset: 0x001C5898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204471, XrefRangeEnd = 204478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x001C76CC File Offset: 0x001C58CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204488, RefRangeEnd = 204489, XrefRangeStart = 204478, XrefRangeEnd = 204488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x001C7700 File Offset: 0x001C5900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204489, XrefRangeEnd = 204589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckTileIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x001C773C File Offset: 0x001C593C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204607, RefRangeEnd = 204608, XrefRangeStart = 204589, XrefRangeEnd = 204607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x001C7770 File Offset: 0x001C5970
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204616, RefRangeEnd = 204619, XrefRangeStart = 204608, XrefRangeEnd = 204616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreMetaReqsMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_AreMetaReqsMet_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x001C77AC File Offset: 0x001C59AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204655, RefRangeEnd = 204656, XrefRangeStart = 204619, XrefRangeEnd = 204655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Constructable_GridBased PlaceNewConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_New_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr3) : null;
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x001C77F8 File Offset: 0x001C59F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204656, XrefRangeEnd = 204670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinalizeMoveConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_FinalizeMoveConstructable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x001C7834 File Offset: 0x001C5A34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204678, RefRangeEnd = 204680, XrefRangeStart = 204670, XrefRangeEnd = 204678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x001C7870 File Offset: 0x001C5A70
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_OutdoorGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x0002F990 File Offset: 0x0002DB90
		public ConstructUpdate_OutdoorGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x060064BD RID: 25789 RVA: 0x001C78AC File Offset: 0x001C5AAC
		// (set) Token: 0x060064BE RID: 25790 RVA: 0x0002F999 File Offset: 0x0002DB99
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x060064BF RID: 25791 RVA: 0x001C78D4 File Offset: 0x001C5AD4
		// (set) Token: 0x060064C0 RID: 25792 RVA: 0x0002F9B4 File Offset: 0x0002DBB4
		public unsafe Constructable_GridBased ConstructableClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_ConstructableClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_ConstructableClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x060064C1 RID: 25793 RVA: 0x001C7904 File Offset: 0x001C5B04
		// (set) Token: 0x060064C2 RID: 25794 RVA: 0x0002F9D3 File Offset: 0x0002DBD3
		public unsafe Transform GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x060064C3 RID: 25795 RVA: 0x001C7934 File Offset: 0x001C5B34
		// (set) Token: 0x060064C4 RID: 25796 RVA: 0x0002F9F2 File Offset: 0x0002DBF2
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x060064C5 RID: 25797 RVA: 0x001C795C File Offset: 0x001C5B5C
		// (set) Token: 0x060064C6 RID: 25798 RVA: 0x0002FA0D File Offset: 0x0002DC0D
		public unsafe float currentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x060064C7 RID: 25799 RVA: 0x001C7984 File Offset: 0x001C5B84
		// (set) Token: 0x060064C8 RID: 25800 RVA: 0x0002FA28 File Offset: 0x0002DC28
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x060064C9 RID: 25801 RVA: 0x001C79B4 File Offset: 0x001C5BB4
		// (set) Token: 0x060064CA RID: 25802 RVA: 0x0002FA47 File Offset: 0x0002DC47
		public unsafe ConstructionManager.WorldIntersection closestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_closestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionManager.WorldIntersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_closestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x060064CB RID: 25803 RVA: 0x001C79E4 File Offset: 0x001C5BE4
		// (set) Token: 0x060064CC RID: 25804 RVA: 0x0002FA66 File Offset: 0x0002DC66
		public unsafe float listingPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_listingPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_listingPrice)) = value;
			}
		}

		// Token: 0x040044B2 RID: 17586
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040044B3 RID: 17587
		private static readonly IntPtr NativeFieldInfoPtr_ConstructableClass;

		// Token: 0x040044B4 RID: 17588
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x040044B5 RID: 17589
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x040044B6 RID: 17590
		private static readonly IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x040044B7 RID: 17591
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x040044B8 RID: 17592
		private static readonly IntPtr NativeFieldInfoPtr_closestIntersection;

		// Token: 0x040044B9 RID: 17593
		private static readonly IntPtr NativeFieldInfoPtr_listingPrice;

		// Token: 0x040044BA RID: 17594
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040044BB RID: 17595
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040044BC RID: 17596
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x040044BD RID: 17597
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x040044BE RID: 17598
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x040044BF RID: 17599
		private static readonly IntPtr NativeMethodInfoPtr_CheckTileIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x040044C0 RID: 17600
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x040044C1 RID: 17601
		private static readonly IntPtr NativeMethodInfoPtr_AreMetaReqsMet_Private_Boolean_0;

		// Token: 0x040044C2 RID: 17602
		private static readonly IntPtr NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_New_Constructable_GridBased_0;

		// Token: 0x040044C3 RID: 17603
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeMoveConstructable_Protected_Virtual_New_Void_0;

		// Token: 0x040044C4 RID: 17604
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0;

		// Token: 0x040044C5 RID: 17605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
