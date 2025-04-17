using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077C RID: 1916
	public class MapPositionUtility : Singleton<MapPositionUtility>
	{
		// Token: 0x0600B58B RID: 46475 RVA: 0x002D20A0 File Offset: 0x002D02A0
		// Note: this type is marked as 'beforefieldinit'.
		static MapPositionUtility()
		{
			Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MapPositionUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr);
			MapPositionUtility.NativeFieldInfoPtr_OriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "OriginPoint");
			MapPositionUtility.NativeFieldInfoPtr_EdgePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "EdgePoint");
			MapPositionUtility.NativeFieldInfoPtr_MapDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "MapDimensions");
			MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "<conversionFactor>k__BackingField");
			MapPositionUtility.NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685611);
			MapPositionUtility.NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685612);
			MapPositionUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685613);
			MapPositionUtility.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685614);
			MapPositionUtility.NativeMethodInfoPtr_Recalculate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685615);
			MapPositionUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685616);
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600B58C RID: 46476 RVA: 0x002D2198 File Offset: 0x002D0398
		// (set) Token: 0x0600B58D RID: 46477 RVA: 0x002D21D4 File Offset: 0x002D03D4
		public unsafe float conversionFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B58E RID: 46478 RVA: 0x002D2214 File Offset: 0x002D0414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310109, XrefRangeEnd = 310119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapPositionUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B58F RID: 46479 RVA: 0x002D2250 File Offset: 0x002D0450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310119, XrefRangeEnd = 310121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetMapPosition(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B590 RID: 46480 RVA: 0x002D229C File Offset: 0x002D049C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310121, XrefRangeEnd = 310128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recalculate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_Recalculate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B591 RID: 46481 RVA: 0x002D22D0 File Offset: 0x002D04D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310128, XrefRangeEnd = 310131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapPositionUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B592 RID: 46482 RVA: 0x000591C5 File Offset: 0x000573C5
		public MapPositionUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600B593 RID: 46483 RVA: 0x002D230C File Offset: 0x002D050C
		// (set) Token: 0x0600B594 RID: 46484 RVA: 0x000591CE File Offset: 0x000573CE
		public unsafe Transform OriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_OriginPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_OriginPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600B595 RID: 46485 RVA: 0x002D233C File Offset: 0x002D053C
		// (set) Token: 0x0600B596 RID: 46486 RVA: 0x000591ED File Offset: 0x000573ED
		public unsafe Transform EdgePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_EdgePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_EdgePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600B597 RID: 46487 RVA: 0x002D236C File Offset: 0x002D056C
		// (set) Token: 0x0600B598 RID: 46488 RVA: 0x0005920C File Offset: 0x0005740C
		public unsafe float MapDimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_MapDimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_MapDimensions)) = value;
			}
		}

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600B599 RID: 46489 RVA: 0x002D2394 File Offset: 0x002D0594
		// (set) Token: 0x0600B59A RID: 46490 RVA: 0x00059227 File Offset: 0x00057427
		public unsafe float _conversionFactor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField)) = value;
			}
		}

		// Token: 0x04007A56 RID: 31318
		private static readonly IntPtr NativeFieldInfoPtr_OriginPoint;

		// Token: 0x04007A57 RID: 31319
		private static readonly IntPtr NativeFieldInfoPtr_EdgePoint;

		// Token: 0x04007A58 RID: 31320
		private static readonly IntPtr NativeFieldInfoPtr_MapDimensions;

		// Token: 0x04007A59 RID: 31321
		private static readonly IntPtr NativeFieldInfoPtr__conversionFactor_k__BackingField;

		// Token: 0x04007A5A RID: 31322
		private static readonly IntPtr NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0;

		// Token: 0x04007A5B RID: 31323
		private static readonly IntPtr NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0;

		// Token: 0x04007A5C RID: 31324
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007A5D RID: 31325
		private static readonly IntPtr NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0;

		// Token: 0x04007A5E RID: 31326
		private static readonly IntPtr NativeMethodInfoPtr_Recalculate_Public_Void_0;

		// Token: 0x04007A5F RID: 31327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
