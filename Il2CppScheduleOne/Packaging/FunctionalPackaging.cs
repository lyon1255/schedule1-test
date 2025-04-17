using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000569 RID: 1385
	public class FunctionalPackaging : Draggable
	{
		// Token: 0x060079AB RID: 31147 RVA: 0x0020C48C File Offset: 0x0020A68C
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalPackaging()
		{
			Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalPackaging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr);
			FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<IsSealed>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<IsFull>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<ReachedOutput>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr_SealInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "SealInstruction");
			FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "AutoEnableSealing");
			FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductContactTime");
			FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductContactMaxVelocity");
			FunctionalPackaging.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "Definition");
			FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "AlignmentPoint");
			FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductAlignmentPoints");
			FunctionalPackaging.NativeFieldInfoPtr_SealSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "SealSound");
			FunctionalPackaging.NativeFieldInfoPtr_PackedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "PackedProducts");
			FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onFullyPacked");
			FunctionalPackaging.NativeFieldInfoPtr_onSealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onSealed");
			FunctionalPackaging.NativeFieldInfoPtr_onReachOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onReachOutput");
			FunctionalPackaging.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "station");
			FunctionalPackaging.NativeFieldInfoPtr_productContactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "productContactTime");
			FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "VelocityCalculator");
			FunctionalPackaging.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678527);
			FunctionalPackaging.NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678528);
			FunctionalPackaging.NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678529);
			FunctionalPackaging.NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678530);
			FunctionalPackaging.NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678531);
			FunctionalPackaging.NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678532);
			FunctionalPackaging.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678533);
			FunctionalPackaging.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678534);
			FunctionalPackaging.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678535);
			FunctionalPackaging.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678536);
			FunctionalPackaging.NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678537);
			FunctionalPackaging.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678538);
			FunctionalPackaging.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678539);
			FunctionalPackaging.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678540);
			FunctionalPackaging.NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678541);
			FunctionalPackaging.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678542);
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x060079AC RID: 31148 RVA: 0x0020C764 File Offset: 0x0020A964
		// (set) Token: 0x060079AD RID: 31149 RVA: 0x0020C7A0 File Offset: 0x0020A9A0
		public unsafe bool IsSealed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x060079AE RID: 31150 RVA: 0x0020C7E0 File Offset: 0x0020A9E0
		// (set) Token: 0x060079AF RID: 31151 RVA: 0x0020C81C File Offset: 0x0020AA1C
		public unsafe bool IsFull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x060079B0 RID: 31152 RVA: 0x0020C85C File Offset: 0x0020AA5C
		// (set) Token: 0x060079B1 RID: 31153 RVA: 0x0020C898 File Offset: 0x0020AA98
		public unsafe bool ReachedOutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x0020C8D8 File Offset: 0x0020AAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233163, XrefRangeEnd = 233175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(PackagingStation _station, Transform alignment, bool align = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x0020C948 File Offset: 0x0020AB48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233205, RefRangeEnd = 233208, XrefRangeStart = 233175, XrefRangeEnd = 233205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x0020C98C File Offset: 0x0020AB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233208, XrefRangeEnd = 233213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x0020C9C8 File Offset: 0x0020ABC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233213, XrefRangeEnd = 233244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x0020CA04 File Offset: 0x0020AC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233244, XrefRangeEnd = 233263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PackProduct(FunctionalProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x0020CA54 File Offset: 0x0020AC54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233281, RefRangeEnd = 233283, XrefRangeStart = 233263, XrefRangeEnd = 233281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x0020CA90 File Offset: 0x0020AC90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233323, RefRangeEnd = 233324, XrefRangeStart = 233283, XrefRangeEnd = 233323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x0020CAE0 File Offset: 0x0020ACE0
		[CallerCount(0)]
		public unsafe virtual void EnableSealing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x0020CB1C File Offset: 0x0020AD1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233347, RefRangeEnd = 233349, XrefRangeStart = 233324, XrefRangeEnd = 233347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x0020CB58 File Offset: 0x0020AD58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233368, RefRangeEnd = 233370, XrefRangeStart = 233349, XrefRangeEnd = 233368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalPackaging() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x00039E80 File Offset: 0x00038080
		public FunctionalPackaging(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x060079BD RID: 31165 RVA: 0x0020CB94 File Offset: 0x0020AD94
		// (set) Token: 0x060079BE RID: 31166 RVA: 0x00039E89 File Offset: 0x00038089
		public unsafe bool _IsSealed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField)) = value;
			}
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x060079BF RID: 31167 RVA: 0x0020CBBC File Offset: 0x0020ADBC
		// (set) Token: 0x060079C0 RID: 31168 RVA: 0x00039EA4 File Offset: 0x000380A4
		public unsafe bool _IsFull_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField)) = value;
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x060079C1 RID: 31169 RVA: 0x0020CBE4 File Offset: 0x0020ADE4
		// (set) Token: 0x060079C2 RID: 31170 RVA: 0x00039EBF File Offset: 0x000380BF
		public unsafe bool _ReachedOutput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField)) = value;
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x060079C3 RID: 31171 RVA: 0x0020CC0C File Offset: 0x0020AE0C
		// (set) Token: 0x060079C4 RID: 31172 RVA: 0x00039EDA File Offset: 0x000380DA
		public unsafe string SealInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealInstruction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealInstruction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x060079C5 RID: 31173 RVA: 0x0020CC34 File Offset: 0x0020AE34
		// (set) Token: 0x060079C6 RID: 31174 RVA: 0x00039EF9 File Offset: 0x000380F9
		public unsafe bool AutoEnableSealing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing)) = value;
			}
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x060079C7 RID: 31175 RVA: 0x0020CC5C File Offset: 0x0020AE5C
		// (set) Token: 0x060079C8 RID: 31176 RVA: 0x00039F14 File Offset: 0x00038114
		public unsafe float ProductContactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime)) = value;
			}
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x060079C9 RID: 31177 RVA: 0x0020CC84 File Offset: 0x0020AE84
		// (set) Token: 0x060079CA RID: 31178 RVA: 0x00039F2F File Offset: 0x0003812F
		public unsafe float ProductContactMaxVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity)) = value;
			}
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x060079CB RID: 31179 RVA: 0x0020CCAC File Offset: 0x0020AEAC
		// (set) Token: 0x060079CC RID: 31180 RVA: 0x00039F4A File Offset: 0x0003814A
		public unsafe PackagingDefinition Definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_Definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x060079CD RID: 31181 RVA: 0x0020CCDC File Offset: 0x0020AEDC
		// (set) Token: 0x060079CE RID: 31182 RVA: 0x00039F69 File Offset: 0x00038169
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x060079CF RID: 31183 RVA: 0x0020CD0C File Offset: 0x0020AF0C
		// (set) Token: 0x060079D0 RID: 31184 RVA: 0x00039F88 File Offset: 0x00038188
		public unsafe Il2CppReferenceArray<Transform> ProductAlignmentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x060079D1 RID: 31185 RVA: 0x0020CD3C File Offset: 0x0020AF3C
		// (set) Token: 0x060079D2 RID: 31186 RVA: 0x00039FA7 File Offset: 0x000381A7
		public unsafe AudioSourceController SealSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x060079D3 RID: 31187 RVA: 0x0020CD6C File Offset: 0x0020AF6C
		// (set) Token: 0x060079D4 RID: 31188 RVA: 0x00039FC6 File Offset: 0x000381C6
		public unsafe List<FunctionalProduct> PackedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_PackedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_PackedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x060079D5 RID: 31189 RVA: 0x0020CD9C File Offset: 0x0020AF9C
		// (set) Token: 0x060079D6 RID: 31190 RVA: 0x00039FE5 File Offset: 0x000381E5
		public unsafe Action onFullyPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x0020CDCC File Offset: 0x0020AFCC
		// (set) Token: 0x060079D8 RID: 31192 RVA: 0x0003A004 File Offset: 0x00038204
		public unsafe Action onSealed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onSealed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onSealed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x060079D9 RID: 31193 RVA: 0x0020CDFC File Offset: 0x0020AFFC
		// (set) Token: 0x060079DA RID: 31194 RVA: 0x0003A023 File Offset: 0x00038223
		public unsafe Action onReachOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onReachOutput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onReachOutput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x060079DB RID: 31195 RVA: 0x0020CE2C File Offset: 0x0020B02C
		// (set) Token: 0x060079DC RID: 31196 RVA: 0x0003A042 File Offset: 0x00038242
		public unsafe PackagingStation station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x060079DD RID: 31197 RVA: 0x0020CE5C File Offset: 0x0020B05C
		// (set) Token: 0x060079DE RID: 31198 RVA: 0x0003A061 File Offset: 0x00038261
		public unsafe Dictionary<FunctionalProduct, float> productContactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_productContactTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FunctionalProduct, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_productContactTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x060079DF RID: 31199 RVA: 0x0020CE8C File Offset: 0x0020B08C
		// (set) Token: 0x060079E0 RID: 31200 RVA: 0x0003A080 File Offset: 0x00038280
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052C7 RID: 21191
		private static readonly IntPtr NativeFieldInfoPtr__IsSealed_k__BackingField;

		// Token: 0x040052C8 RID: 21192
		private static readonly IntPtr NativeFieldInfoPtr__IsFull_k__BackingField;

		// Token: 0x040052C9 RID: 21193
		private static readonly IntPtr NativeFieldInfoPtr__ReachedOutput_k__BackingField;

		// Token: 0x040052CA RID: 21194
		private static readonly IntPtr NativeFieldInfoPtr_SealInstruction;

		// Token: 0x040052CB RID: 21195
		private static readonly IntPtr NativeFieldInfoPtr_AutoEnableSealing;

		// Token: 0x040052CC RID: 21196
		private static readonly IntPtr NativeFieldInfoPtr_ProductContactTime;

		// Token: 0x040052CD RID: 21197
		private static readonly IntPtr NativeFieldInfoPtr_ProductContactMaxVelocity;

		// Token: 0x040052CE RID: 21198
		private static readonly IntPtr NativeFieldInfoPtr_Definition;

		// Token: 0x040052CF RID: 21199
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x040052D0 RID: 21200
		private static readonly IntPtr NativeFieldInfoPtr_ProductAlignmentPoints;

		// Token: 0x040052D1 RID: 21201
		private static readonly IntPtr NativeFieldInfoPtr_SealSound;

		// Token: 0x040052D2 RID: 21202
		private static readonly IntPtr NativeFieldInfoPtr_PackedProducts;

		// Token: 0x040052D3 RID: 21203
		private static readonly IntPtr NativeFieldInfoPtr_onFullyPacked;

		// Token: 0x040052D4 RID: 21204
		private static readonly IntPtr NativeFieldInfoPtr_onSealed;

		// Token: 0x040052D5 RID: 21205
		private static readonly IntPtr NativeFieldInfoPtr_onReachOutput;

		// Token: 0x040052D6 RID: 21206
		private static readonly IntPtr NativeFieldInfoPtr_station;

		// Token: 0x040052D7 RID: 21207
		private static readonly IntPtr NativeFieldInfoPtr_productContactTime;

		// Token: 0x040052D8 RID: 21208
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x040052D9 RID: 21209
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0;

		// Token: 0x040052DA RID: 21210
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0;

		// Token: 0x040052DB RID: 21211
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0;

		// Token: 0x040052DC RID: 21212
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0;

		// Token: 0x040052DD RID: 21213
		private static readonly IntPtr NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0;

		// Token: 0x040052DE RID: 21214
		private static readonly IntPtr NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0;

		// Token: 0x040052DF RID: 21215
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0;

		// Token: 0x040052E0 RID: 21216
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0;

		// Token: 0x040052E1 RID: 21217
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x040052E2 RID: 21218
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x040052E3 RID: 21219
		private static readonly IntPtr NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0;

		// Token: 0x040052E4 RID: 21220
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0;

		// Token: 0x040052E5 RID: 21221
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x040052E6 RID: 21222
		private static readonly IntPtr NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0;

		// Token: 0x040052E7 RID: 21223
		private static readonly IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0;

		// Token: 0x040052E8 RID: 21224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
