using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000670 RID: 1648
	public class TrashBagCanvas : Singleton<TrashBagCanvas>
	{
		// Token: 0x06009311 RID: 37649 RVA: 0x0025E054 File Offset: 0x0025C254
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBagCanvas()
		{
			Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TrashBagCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr);
			TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "<IsOpen>k__BackingField");
			TrashBagCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "Canvas");
			TrashBagCanvas.NativeFieldInfoPtr_InputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "InputPrompt");
			TrashBagCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681529);
			TrashBagCanvas.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681530);
			TrashBagCanvas.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681531);
			TrashBagCanvas.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681532);
			TrashBagCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681533);
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x06009312 RID: 37650 RVA: 0x0025E124 File Offset: 0x0025C324
		// (set) Token: 0x06009313 RID: 37651 RVA: 0x0025E160 File Offset: 0x0025C360
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009314 RID: 37652 RVA: 0x0025E1A0 File Offset: 0x0025C3A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264882, RefRangeEnd = 264883, XrefRangeStart = 264880, XrefRangeEnd = 264882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009315 RID: 37653 RVA: 0x0025E1D4 File Offset: 0x0025C3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264885, RefRangeEnd = 264886, XrefRangeStart = 264883, XrefRangeEnd = 264885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009316 RID: 37654 RVA: 0x0025E208 File Offset: 0x0025C408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264886, XrefRangeEnd = 264889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBagCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x000473CE File Offset: 0x000455CE
		public TrashBagCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x06009318 RID: 37656 RVA: 0x0025E244 File Offset: 0x0025C444
		// (set) Token: 0x06009319 RID: 37657 RVA: 0x000473D7 File Offset: 0x000455D7
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x0600931A RID: 37658 RVA: 0x0025E26C File Offset: 0x0025C46C
		// (set) Token: 0x0600931B RID: 37659 RVA: 0x000473F2 File Offset: 0x000455F2
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x0600931C RID: 37660 RVA: 0x0025E29C File Offset: 0x0025C49C
		// (set) Token: 0x0600931D RID: 37661 RVA: 0x00047411 File Offset: 0x00045611
		public unsafe InputPrompt InputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_InputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_InputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400634B RID: 25419
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400634C RID: 25420
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400634D RID: 25421
		private static readonly IntPtr NativeFieldInfoPtr_InputPrompt;

		// Token: 0x0400634E RID: 25422
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400634F RID: 25423
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006350 RID: 25424
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006351 RID: 25425
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006352 RID: 25426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
