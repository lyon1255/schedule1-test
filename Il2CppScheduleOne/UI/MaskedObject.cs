using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066B RID: 1643
	public class MaskedObject : UIBehaviour
	{
		// Token: 0x060092B2 RID: 37554 RVA: 0x0025D074 File Offset: 0x0025B274
		// Note: this type is marked as 'beforefieldinit'.
		static MaskedObject()
		{
			Il2CppClassPointerStore<MaskedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "MaskedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr);
			MaskedObject.NativeFieldInfoPtr_canvasRendererToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "canvasRendererToClip");
			MaskedObject.NativeFieldInfoPtr_includeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "includeChildren");
			MaskedObject.NativeFieldInfoPtr_rootCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "rootCanvas");
			MaskedObject.NativeFieldInfoPtr_maskRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "maskRectTransform");
			MaskedObject.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "initialized");
			MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "canvasRenderersToClip");
			MaskedObject.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681502);
			MaskedObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681503);
			MaskedObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681504);
			MaskedObject.NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681505);
			MaskedObject.NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681506);
			MaskedObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681507);
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x0025D194 File Offset: 0x0025B394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264686, XrefRangeEnd = 264688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x0025D1D0 File Offset: 0x0025B3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264688, XrefRangeEnd = 264692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x0025D20C File Offset: 0x0025B40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264692, XrefRangeEnd = 264710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092B6 RID: 37558 RVA: 0x0025D248 File Offset: 0x0025B448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264710, XrefRangeEnd = 264713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Canvas rootCanvas, RectTransform maskRectTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootCanvas);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(maskRectTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x0025D29C File Offset: 0x0025B49C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 264732, RefRangeEnd = 264736, XrefRangeStart = 264713, XrefRangeEnd = 264732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetClippingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x0025D2D0 File Offset: 0x0025B4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264736, XrefRangeEnd = 264744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskedObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x00047028 File Offset: 0x00045228
		public MaskedObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x060092BA RID: 37562 RVA: 0x0025D30C File Offset: 0x0025B50C
		// (set) Token: 0x060092BB RID: 37563 RVA: 0x00047031 File Offset: 0x00045231
		public unsafe CanvasRenderer canvasRendererToClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRendererToClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRendererToClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x060092BC RID: 37564 RVA: 0x0025D33C File Offset: 0x0025B53C
		// (set) Token: 0x060092BD RID: 37565 RVA: 0x00047050 File Offset: 0x00045250
		public unsafe bool includeChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_includeChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_includeChildren)) = value;
			}
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x060092BE RID: 37566 RVA: 0x0025D364 File Offset: 0x0025B564
		// (set) Token: 0x060092BF RID: 37567 RVA: 0x0004706B File Offset: 0x0004526B
		public unsafe Canvas rootCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_rootCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_rootCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x060092C0 RID: 37568 RVA: 0x0025D394 File Offset: 0x0025B594
		// (set) Token: 0x060092C1 RID: 37569 RVA: 0x0004708A File Offset: 0x0004528A
		public unsafe RectTransform maskRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_maskRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_maskRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x060092C2 RID: 37570 RVA: 0x0025D3C4 File Offset: 0x0025B5C4
		// (set) Token: 0x060092C3 RID: 37571 RVA: 0x000470A9 File Offset: 0x000452A9
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x060092C4 RID: 37572 RVA: 0x0025D3EC File Offset: 0x0025B5EC
		// (set) Token: 0x060092C5 RID: 37573 RVA: 0x000470C4 File Offset: 0x000452C4
		public unsafe List<CanvasRenderer> canvasRenderersToClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006315 RID: 25365
		private static readonly IntPtr NativeFieldInfoPtr_canvasRendererToClip;

		// Token: 0x04006316 RID: 25366
		private static readonly IntPtr NativeFieldInfoPtr_includeChildren;

		// Token: 0x04006317 RID: 25367
		private static readonly IntPtr NativeFieldInfoPtr_rootCanvas;

		// Token: 0x04006318 RID: 25368
		private static readonly IntPtr NativeFieldInfoPtr_maskRectTransform;

		// Token: 0x04006319 RID: 25369
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400631A RID: 25370
		private static readonly IntPtr NativeFieldInfoPtr_canvasRenderersToClip;

		// Token: 0x0400631B RID: 25371
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x0400631C RID: 25372
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400631D RID: 25373
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400631E RID: 25374
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0;

		// Token: 0x0400631F RID: 25375
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0;

		// Token: 0x04006320 RID: 25376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
