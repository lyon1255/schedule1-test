using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2Cpp
{
	// Token: 0x02000015 RID: 21
	public class SColorPicker : ColorPicker
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00075370 File Offset: 0x00073570
		// Note: this type is marked as 'beforefieldinit'.
		static SColorPicker()
		{
			Il2CppClassPointerStore<SColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr);
			SColorPicker.NativeFieldInfoPtr_PropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, "PropertyIndex");
			SColorPicker.NativeFieldInfoPtr_onValueChangeWithIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, "onValueChangeWithIndex");
			SColorPicker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, 100663419);
			SColorPicker.NativeMethodInfoPtr_ValueChanged_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, 100663420);
			SColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, 100663421);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00075404 File Offset: 0x00073604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71999, XrefRangeEnd = 72009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SColorPicker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00075438 File Offset: 0x00073638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72009, XrefRangeEnd = 72012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SColorPicker.NativeMethodInfoPtr_ValueChanged_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00075478 File Offset: 0x00073678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72012, XrefRangeEnd = 72013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002D09 File Offset: 0x00000F09
		public SColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000754B4 File Offset: 0x000736B4
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002D12 File Offset: 0x00000F12
		public unsafe int PropertyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_PropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_PropertyIndex)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000754DC File Offset: 0x000736DC
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002D2D File Offset: 0x00000F2D
		public unsafe UnityEvent<Color, int> onValueChangeWithIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_onValueChangeWithIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Color, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_onValueChangeWithIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_PropertyIndex;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_onValueChangeWithIndex;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Private_Void_Color_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
