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
	// Token: 0x0200065E RID: 1630
	public class ProgressSlider : Singleton<ProgressSlider>
	{
		// Token: 0x0600919F RID: 37279 RVA: 0x00259ACC File Offset: 0x00257CCC
		// Note: this type is marked as 'beforefieldinit'.
		static ProgressSlider()
		{
			Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ProgressSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr);
			ProgressSlider.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Container");
			ProgressSlider.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Label");
			ProgressSlider.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Slider");
			ProgressSlider.NativeFieldInfoPtr_SliderFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "SliderFill");
			ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "progressSetThisFrame");
			ProgressSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681348);
			ProgressSlider.NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681349);
			ProgressSlider.NativeMethodInfoPtr_Configure_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681350);
			ProgressSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681351);
		}

		// Token: 0x060091A0 RID: 37280 RVA: 0x00259BB0 File Offset: 0x00257DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263221, XrefRangeEnd = 263223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x00259BE4 File Offset: 0x00257DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263224, RefRangeEnd = 263225, XrefRangeStart = 263223, XrefRangeEnd = 263224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x00259C24 File Offset: 0x00257E24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263225, RefRangeEnd = 263227, XrefRangeStart = 263225, XrefRangeEnd = 263225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(string label, Color sliderFillColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sliderFillColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_Configure_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091A3 RID: 37283 RVA: 0x00259C74 File Offset: 0x00257E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263227, XrefRangeEnd = 263230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProgressSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091A4 RID: 37284 RVA: 0x000466C6 File Offset: 0x000448C6
		public ProgressSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x060091A5 RID: 37285 RVA: 0x00259CB0 File Offset: 0x00257EB0
		// (set) Token: 0x060091A6 RID: 37286 RVA: 0x000466CF File Offset: 0x000448CF
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x060091A7 RID: 37287 RVA: 0x00259CE0 File Offset: 0x00257EE0
		// (set) Token: 0x060091A8 RID: 37288 RVA: 0x000466EE File Offset: 0x000448EE
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x060091A9 RID: 37289 RVA: 0x00259D10 File Offset: 0x00257F10
		// (set) Token: 0x060091AA RID: 37290 RVA: 0x0004670D File Offset: 0x0004490D
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x060091AB RID: 37291 RVA: 0x00259D40 File Offset: 0x00257F40
		// (set) Token: 0x060091AC RID: 37292 RVA: 0x0004672C File Offset: 0x0004492C
		public unsafe Image SliderFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_SliderFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_SliderFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x060091AD RID: 37293 RVA: 0x00259D70 File Offset: 0x00257F70
		// (set) Token: 0x060091AE RID: 37294 RVA: 0x0004674B File Offset: 0x0004494B
		public unsafe bool progressSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame)) = value;
			}
		}

		// Token: 0x04006267 RID: 25191
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006268 RID: 25192
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006269 RID: 25193
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x0400626A RID: 25194
		private static readonly IntPtr NativeFieldInfoPtr_SliderFill;

		// Token: 0x0400626B RID: 25195
		private static readonly IntPtr NativeFieldInfoPtr_progressSetThisFrame;

		// Token: 0x0400626C RID: 25196
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400626D RID: 25197
		private static readonly IntPtr NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0;

		// Token: 0x0400626E RID: 25198
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_String_Color_0;

		// Token: 0x0400626F RID: 25199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
