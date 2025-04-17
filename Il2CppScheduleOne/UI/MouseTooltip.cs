using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000649 RID: 1609
	public class MouseTooltip : Singleton<MouseTooltip>
	{
		// Token: 0x06008EB0 RID: 36528 RVA: 0x002512E0 File Offset: 0x0024F4E0
		// Note: this type is marked as 'beforefieldinit'.
		static MouseTooltip()
		{
			Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "MouseTooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr);
			MouseTooltip.NativeFieldInfoPtr_IconRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconRect");
			MouseTooltip.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconImg");
			MouseTooltip.NativeFieldInfoPtr_TooltipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipRect");
			MouseTooltip.NativeFieldInfoPtr_TooltipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipLabel");
			MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipOffset_NoIcon");
			MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipOffset_WithIcon");
			MouseTooltip.NativeFieldInfoPtr_IconOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconOffset");
			MouseTooltip.NativeFieldInfoPtr_Color_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "Color_Invalid");
			MouseTooltip.NativeFieldInfoPtr_Sprite_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "Sprite_Cross");
			MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "tooltipShownThisFrame");
			MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "iconShownThisFrame");
			MouseTooltip.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681011);
			MouseTooltip.NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681012);
			MouseTooltip.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681013);
			MouseTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681014);
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x0025143C File Offset: 0x0024F63C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259368, RefRangeEnd = 259369, XrefRangeStart = 259368, XrefRangeEnd = 259368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTooltip(string text, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x0025148C File Offset: 0x0024F68C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259370, RefRangeEnd = 259371, XrefRangeStart = 259369, XrefRangeEnd = 259370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowIcon(Sprite sprite, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x002514DC File Offset: 0x0024F6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259371, XrefRangeEnd = 259381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x00251510 File Offset: 0x0024F710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259381, XrefRangeEnd = 259384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseTooltip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x00044AD6 File Offset: 0x00042CD6
		public MouseTooltip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x06008EB6 RID: 36534 RVA: 0x0025154C File Offset: 0x0024F74C
		// (set) Token: 0x06008EB7 RID: 36535 RVA: 0x00044ADF File Offset: 0x00042CDF
		public unsafe RectTransform IconRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x06008EB8 RID: 36536 RVA: 0x0025157C File Offset: 0x0024F77C
		// (set) Token: 0x06008EB9 RID: 36537 RVA: 0x00044AFE File Offset: 0x00042CFE
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x06008EBA RID: 36538 RVA: 0x002515AC File Offset: 0x0024F7AC
		// (set) Token: 0x06008EBB RID: 36539 RVA: 0x00044B1D File Offset: 0x00042D1D
		public unsafe RectTransform TooltipRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x06008EBC RID: 36540 RVA: 0x002515DC File Offset: 0x0024F7DC
		// (set) Token: 0x06008EBD RID: 36541 RVA: 0x00044B3C File Offset: 0x00042D3C
		public unsafe TextMeshProUGUI TooltipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x06008EBE RID: 36542 RVA: 0x0025160C File Offset: 0x0024F80C
		// (set) Token: 0x06008EBF RID: 36543 RVA: 0x00044B5B File Offset: 0x00042D5B
		public unsafe Vector3 TooltipOffset_NoIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon)) = value;
			}
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x06008EC0 RID: 36544 RVA: 0x00251634 File Offset: 0x0024F834
		// (set) Token: 0x06008EC1 RID: 36545 RVA: 0x00044B76 File Offset: 0x00042D76
		public unsafe Vector3 TooltipOffset_WithIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon)) = value;
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x06008EC2 RID: 36546 RVA: 0x0025165C File Offset: 0x0024F85C
		// (set) Token: 0x06008EC3 RID: 36547 RVA: 0x00044B91 File Offset: 0x00042D91
		public unsafe Vector3 IconOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconOffset)) = value;
			}
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x06008EC4 RID: 36548 RVA: 0x00251684 File Offset: 0x0024F884
		// (set) Token: 0x06008EC5 RID: 36549 RVA: 0x00044BAC File Offset: 0x00042DAC
		public unsafe Color Color_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Color_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Color_Invalid)) = value;
			}
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x06008EC6 RID: 36550 RVA: 0x002516AC File Offset: 0x0024F8AC
		// (set) Token: 0x06008EC7 RID: 36551 RVA: 0x00044BC7 File Offset: 0x00042DC7
		public unsafe Sprite Sprite_Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Sprite_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Sprite_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x06008EC8 RID: 36552 RVA: 0x002516DC File Offset: 0x0024F8DC
		// (set) Token: 0x06008EC9 RID: 36553 RVA: 0x00044BE6 File Offset: 0x00042DE6
		public unsafe bool tooltipShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame)) = value;
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x06008ECA RID: 36554 RVA: 0x00251704 File Offset: 0x0024F904
		// (set) Token: 0x06008ECB RID: 36555 RVA: 0x00044C01 File Offset: 0x00042E01
		public unsafe bool iconShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame)) = value;
			}
		}

		// Token: 0x04006095 RID: 24725
		private static readonly IntPtr NativeFieldInfoPtr_IconRect;

		// Token: 0x04006096 RID: 24726
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04006097 RID: 24727
		private static readonly IntPtr NativeFieldInfoPtr_TooltipRect;

		// Token: 0x04006098 RID: 24728
		private static readonly IntPtr NativeFieldInfoPtr_TooltipLabel;

		// Token: 0x04006099 RID: 24729
		private static readonly IntPtr NativeFieldInfoPtr_TooltipOffset_NoIcon;

		// Token: 0x0400609A RID: 24730
		private static readonly IntPtr NativeFieldInfoPtr_TooltipOffset_WithIcon;

		// Token: 0x0400609B RID: 24731
		private static readonly IntPtr NativeFieldInfoPtr_IconOffset;

		// Token: 0x0400609C RID: 24732
		private static readonly IntPtr NativeFieldInfoPtr_Color_Invalid;

		// Token: 0x0400609D RID: 24733
		private static readonly IntPtr NativeFieldInfoPtr_Sprite_Cross;

		// Token: 0x0400609E RID: 24734
		private static readonly IntPtr NativeFieldInfoPtr_tooltipShownThisFrame;

		// Token: 0x0400609F RID: 24735
		private static readonly IntPtr NativeFieldInfoPtr_iconShownThisFrame;

		// Token: 0x040060A0 RID: 24736
		private static readonly IntPtr NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0;

		// Token: 0x040060A1 RID: 24737
		private static readonly IntPtr NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0;

		// Token: 0x040060A2 RID: 24738
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040060A3 RID: 24739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
