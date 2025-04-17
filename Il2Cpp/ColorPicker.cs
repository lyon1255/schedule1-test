using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x0200001F RID: 31
	public class ColorPicker : MonoBehaviour
	{
		// Token: 0x060001DB RID: 475 RVA: 0x0007654C File Offset: 0x0007474C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorPicker()
		{
			Il2CppClassPointerStore<ColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr);
			ColorPicker.NativeFieldInfoPtr_mainImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "mainImage");
			ColorPicker.NativeFieldInfoPtr_pickerIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "pickerIcon");
			ColorPicker.NativeFieldInfoPtr_colorPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "colorPreview");
			ColorPicker.NativeFieldInfoPtr__activeCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "_activeCursor");
			ColorPicker.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "offset");
			ColorPicker.NativeFieldInfoPtr_UIControllerDEMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "UIControllerDEMO");
			ColorPicker.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "Canvas");
			ColorPicker.NativeFieldInfoPtr__findColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "_findColor");
			ColorPicker.NativeFieldInfoPtr_realSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "realSize");
			ColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663471);
			ColorPicker.NativeMethodInfoPtr_CursorEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663472);
			ColorPicker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663473);
			ColorPicker.NativeMethodInfoPtr_CursorMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663474);
			ColorPicker.NativeMethodInfoPtr_CursorPickSkin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663475);
			ColorPicker.NativeMethodInfoPtr_CursorPickEye_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663476);
			ColorPicker.NativeMethodInfoPtr_CursorPickHair_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663477);
			ColorPicker.NativeMethodInfoPtr_CursorPickUnderpants_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663478);
			ColorPicker.NativeMethodInfoPtr_CursorExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663479);
			ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663480);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000766F8 File Offset: 0x000748F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72294, XrefRangeEnd = 72298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0007672C File Offset: 0x0007492C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72298, XrefRangeEnd = 72302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00076760 File Offset: 0x00074960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72302, XrefRangeEnd = 72303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00076794 File Offset: 0x00074994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72316, RefRangeEnd = 72317, XrefRangeStart = 72303, XrefRangeEnd = 72316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000767C8 File Offset: 0x000749C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72317, XrefRangeEnd = 72318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorPickSkin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorPickSkin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000767FC File Offset: 0x000749FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72318, XrefRangeEnd = 72319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorPickEye()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorPickEye_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00076830 File Offset: 0x00074A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72319, XrefRangeEnd = 72320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorPickHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorPickHair_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00076864 File Offset: 0x00074A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72320, XrefRangeEnd = 72321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorPickUnderpants()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorPickUnderpants_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00076898 File Offset: 0x00074A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72321, XrefRangeEnd = 72325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000768CC File Offset: 0x00074ACC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00003052 File Offset: 0x00001252
		public ColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00076908 File Offset: 0x00074B08
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000305B File Offset: 0x0000125B
		public unsafe Image mainImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_mainImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_mainImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00076938 File Offset: 0x00074B38
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000307A File Offset: 0x0000127A
		public unsafe RectTransform pickerIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_pickerIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_pickerIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00076968 File Offset: 0x00074B68
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00003099 File Offset: 0x00001299
		public unsafe Image colorPreview
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_colorPreview);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_colorPreview), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00076998 File Offset: 0x00074B98
		// (set) Token: 0x060001EE RID: 494 RVA: 0x000030B8 File Offset: 0x000012B8
		public unsafe bool _activeCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr__activeCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr__activeCursor)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000769C0 File Offset: 0x00074BC0
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x000030D3 File Offset: 0x000012D3
		public unsafe Vector2 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000769E8 File Offset: 0x00074BE8
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x000030EE File Offset: 0x000012EE
		public unsafe UIControllerDEMO UIControllerDEMO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_UIControllerDEMO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIControllerDEMO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_UIControllerDEMO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00076A18 File Offset: 0x00074C18
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0000310D File Offset: 0x0000130D
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00076A48 File Offset: 0x00074C48
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0000312C File Offset: 0x0000132C
		public unsafe Color _findColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr__findColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr__findColor)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00076A70 File Offset: 0x00074C70
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00003147 File Offset: 0x00001347
		public unsafe Vector2 realSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_realSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_realSize)) = value;
			}
		}

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_mainImage;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_pickerIcon;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_colorPreview;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr__activeCursor;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_UIControllerDEMO;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr__findColor;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_realSize;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_CursorEnter_Public_Void_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_CursorMove_Public_Void_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_CursorPickSkin_Public_Void_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_CursorPickEye_Public_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_CursorPickHair_Public_Void_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_CursorPickUnderpants_Public_Void_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_CursorExit_Public_Void_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
