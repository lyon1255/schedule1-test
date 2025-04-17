using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062E RID: 1582
	public class CrosshairText : MonoBehaviour
	{
		// Token: 0x06008B9F RID: 35743 RVA: 0x00248104 File Offset: 0x00246304
		// Note: this type is marked as 'beforefieldinit'.
		static CrosshairText()
		{
			Il2CppClassPointerStore<CrosshairText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CrosshairText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr);
			CrosshairText.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, "Label");
			CrosshairText.NativeFieldInfoPtr_setThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, "setThisFrame");
			CrosshairText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680637);
			CrosshairText.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680638);
			CrosshairText.NativeMethodInfoPtr_Show_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680639);
			CrosshairText.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680640);
			CrosshairText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680641);
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x002481C0 File Offset: 0x002463C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x002481F4 File Offset: 0x002463F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255646, XrefRangeEnd = 255647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x00248228 File Offset: 0x00246428
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255650, RefRangeEnd = 255653, XrefRangeStart = 255647, XrefRangeEnd = 255650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(string text, Color col = default(Color))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Show_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x00248278 File Offset: 0x00246478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BA4 RID: 35748 RVA: 0x002482AC File Offset: 0x002464AC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrosshairText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BA5 RID: 35749 RVA: 0x00042DE1 File Offset: 0x00040FE1
		public CrosshairText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x06008BA6 RID: 35750 RVA: 0x002482E8 File Offset: 0x002464E8
		// (set) Token: 0x06008BA7 RID: 35751 RVA: 0x00042DEA File Offset: 0x00040FEA
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x06008BA8 RID: 35752 RVA: 0x00248318 File Offset: 0x00246518
		// (set) Token: 0x06008BA9 RID: 35753 RVA: 0x00042E09 File Offset: 0x00041009
		public unsafe bool setThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_setThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_setThisFrame)) = value;
			}
		}

		// Token: 0x04005EAA RID: 24234
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04005EAB RID: 24235
		private static readonly IntPtr NativeFieldInfoPtr_setThisFrame;

		// Token: 0x04005EAC RID: 24236
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005EAD RID: 24237
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005EAE RID: 24238
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_String_Color_0;

		// Token: 0x04005EAF RID: 24239
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04005EB0 RID: 24240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
