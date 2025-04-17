﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B3 RID: 435
	public class DeaddropQuest : Quest
	{
		// Token: 0x060025F7 RID: 9719 RVA: 0x000E7A80 File Offset: 0x000E5C80
		// Note: this type is marked as 'beforefieldinit'.
		static DeaddropQuest()
		{
			Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "DeaddropQuest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr);
			DeaddropQuest.NativeFieldInfoPtr_DeaddropQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, "DeaddropQuests");
			DeaddropQuest.NativeFieldInfoPtr__Drop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, "<Drop>k__BackingField");
			DeaddropQuest.NativeMethodInfoPtr_get_Drop_Public_get_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, 100667544);
			DeaddropQuest.NativeMethodInfoPtr_set_Drop_Private_set_Void_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, 100667545);
			DeaddropQuest.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, 100667546);
			DeaddropQuest.NativeMethodInfoPtr_SetDrop_Public_Void_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, 100667547);
			DeaddropQuest.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, 100667548);
			DeaddropQuest.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, 100667549);
			DeaddropQuest.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, 100667550);
			DeaddropQuest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, 100667551);
			DeaddropQuest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr, 100667552);
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000E7B8C File Offset: 0x000E5D8C
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x000E7BCC File Offset: 0x000E5DCC
		public unsafe DeadDrop Drop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeaddropQuest.NativeMethodInfoPtr_get_Drop_Public_get_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeaddropQuest.NativeMethodInfoPtr_set_Drop_Private_set_Void_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000E7C10 File Offset: 0x000E5E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116406, XrefRangeEnd = 116420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeaddropQuest.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x000E7C5C File Offset: 0x000E5E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116427, RefRangeEnd = 116428, XrefRangeStart = 116420, XrefRangeEnd = 116427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDrop(DeadDrop drop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(drop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeaddropQuest.NativeMethodInfoPtr_SetDrop_Public_Void_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000E7CA0 File Offset: 0x000E5EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116428, XrefRangeEnd = 116434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeaddropQuest.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x000E7CDC File Offset: 0x000E5EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116434, XrefRangeEnd = 116442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeaddropQuest.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x000E7D10 File Offset: 0x000E5F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116442, XrefRangeEnd = 116451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeaddropQuest.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x000E7D4C File Offset: 0x000E5F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116451, XrefRangeEnd = 116481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeaddropQuest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x000E7D90 File Offset: 0x000E5F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116481, XrefRangeEnd = 116485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeaddropQuest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeaddropQuest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeaddropQuest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x000151B5 File Offset: 0x000133B5
		public DeaddropQuest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000E7DCC File Offset: 0x000E5FCC
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x000151BE File Offset: 0x000133BE
		public unsafe static List<DeaddropQuest> DeaddropQuests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeaddropQuest.NativeFieldInfoPtr_DeaddropQuests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeaddropQuest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeaddropQuest.NativeFieldInfoPtr_DeaddropQuests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000E7DF4 File Offset: 0x000E5FF4
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x000151D0 File Offset: 0x000133D0
		public unsafe DeadDrop _Drop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeaddropQuest.NativeFieldInfoPtr__Drop_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeaddropQuest.NativeFieldInfoPtr__Drop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropQuests;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeFieldInfoPtr__Drop_k__BackingField;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr_get_Drop_Public_get_DeadDrop_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_set_Drop_Private_set_Void_DeadDrop_0;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeMethodInfoPtr_SetDrop_Public_Void_DeadDrop_0;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
