using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200056A RID: 1386
	public class FunctionalProduct : Draggable
	{
		// Token: 0x060079E1 RID: 31201 RVA: 0x0020CEBC File Offset: 0x0020B0BC
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalProduct()
		{
			Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr);
			FunctionalProduct.NativeFieldInfoPtr_ClampZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "ClampZ");
			FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "AlignmentPoint");
			FunctionalProduct.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "Visuals");
			FunctionalProduct.NativeFieldInfoPtr_startLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "startLocalPos");
			FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "lowestMaxZ");
			FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "<VelocityCalculator>k__BackingField");
			FunctionalProduct.NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678543);
			FunctionalProduct.NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678544);
			FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678545);
			FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678546);
			FunctionalProduct.NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678547);
			FunctionalProduct.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678548);
			FunctionalProduct.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678549);
			FunctionalProduct.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678550);
			FunctionalProduct.NativeMethodInfoPtr_Clamp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678551);
			FunctionalProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678552);
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x060079E2 RID: 31202 RVA: 0x0020D02C File Offset: 0x0020B22C
		// (set) Token: 0x060079E3 RID: 31203 RVA: 0x0020D06C File Offset: 0x0020B26C
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x0020D0B0 File Offset: 0x0020B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233370, XrefRangeEnd = 233388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(PackagingStation station, ItemInstance item, Transform alignment, bool align = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x0020D130 File Offset: 0x0020B330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233388, XrefRangeEnd = 233405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x0020D180 File Offset: 0x0020B380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233405, XrefRangeEnd = 233413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeVisuals(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x0020D1D0 File Offset: 0x0020B3D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233426, RefRangeEnd = 233428, XrefRangeStart = 233413, XrefRangeEnd = 233426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x0020D214 File Offset: 0x0020B414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233428, XrefRangeEnd = 233429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x0020D250 File Offset: 0x0020B450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233429, XrefRangeEnd = 233441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x0020D28C File Offset: 0x0020B48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233441, XrefRangeEnd = 233452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_Clamp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x0020D2C0 File Offset: 0x0020B4C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233453, RefRangeEnd = 233455, XrefRangeStart = 233452, XrefRangeEnd = 233453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x0003A09F File Offset: 0x0003829F
		public FunctionalProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x060079ED RID: 31213 RVA: 0x0020D2FC File Offset: 0x0020B4FC
		// (set) Token: 0x060079EE RID: 31214 RVA: 0x0003A0A8 File Offset: 0x000382A8
		public unsafe bool ClampZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_ClampZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_ClampZ)) = value;
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x060079EF RID: 31215 RVA: 0x0020D324 File Offset: 0x0020B524
		// (set) Token: 0x060079F0 RID: 31216 RVA: 0x0003A0C3 File Offset: 0x000382C3
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x060079F1 RID: 31217 RVA: 0x0020D354 File Offset: 0x0020B554
		// (set) Token: 0x060079F2 RID: 31218 RVA: 0x0003A0E2 File Offset: 0x000382E2
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x060079F3 RID: 31219 RVA: 0x0020D384 File Offset: 0x0020B584
		// (set) Token: 0x060079F4 RID: 31220 RVA: 0x0003A101 File Offset: 0x00038301
		public unsafe Vector3 startLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_startLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_startLocalPos)) = value;
			}
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x060079F5 RID: 31221 RVA: 0x0020D3AC File Offset: 0x0020B5AC
		// (set) Token: 0x060079F6 RID: 31222 RVA: 0x0003A11C File Offset: 0x0003831C
		public unsafe float lowestMaxZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ)) = value;
			}
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x060079F7 RID: 31223 RVA: 0x0020D3D4 File Offset: 0x0020B5D4
		// (set) Token: 0x060079F8 RID: 31224 RVA: 0x0003A137 File Offset: 0x00038337
		public unsafe SmoothedVelocityCalculator _VelocityCalculator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052E9 RID: 21225
		private static readonly IntPtr NativeFieldInfoPtr_ClampZ;

		// Token: 0x040052EA RID: 21226
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x040052EB RID: 21227
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040052EC RID: 21228
		private static readonly IntPtr NativeFieldInfoPtr_startLocalPos;

		// Token: 0x040052ED RID: 21229
		private static readonly IntPtr NativeFieldInfoPtr_lowestMaxZ;

		// Token: 0x040052EE RID: 21230
		private static readonly IntPtr NativeFieldInfoPtr__VelocityCalculator_k__BackingField;

		// Token: 0x040052EF RID: 21231
		private static readonly IntPtr NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0;

		// Token: 0x040052F0 RID: 21232
		private static readonly IntPtr NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0;

		// Token: 0x040052F1 RID: 21233
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0;

		// Token: 0x040052F2 RID: 21234
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x040052F3 RID: 21235
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x040052F4 RID: 21236
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0;

		// Token: 0x040052F5 RID: 21237
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x040052F6 RID: 21238
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x040052F7 RID: 21239
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Private_Void_0;

		// Token: 0x040052F8 RID: 21240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
