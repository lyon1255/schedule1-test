using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000701 RID: 1793
	public class CharacterCreatorToggle : CharacterCreatorField<int>
	{
		// Token: 0x0600A0C2 RID: 41154 RVA: 0x002875D0 File Offset: 0x002857D0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorToggle()
		{
			Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr);
			CharacterCreatorToggle.NativeFieldInfoPtr_Button1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, "Button1");
			CharacterCreatorToggle.NativeFieldInfoPtr_Button2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, "Button2");
			CharacterCreatorToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682960);
			CharacterCreatorToggle.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682961);
			CharacterCreatorToggle.NativeMethodInfoPtr_OnButton1_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682962);
			CharacterCreatorToggle.NativeMethodInfoPtr_OnButton2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682963);
			CharacterCreatorToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682964);
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x0028768C File Offset: 0x0028588C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282561, XrefRangeEnd = 282575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x002876C8 File Offset: 0x002858C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282575, XrefRangeEnd = 282582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorToggle.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x00287704 File Offset: 0x00285904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282582, XrefRangeEnd = 282583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButton1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr_OnButton1_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x00287738 File Offset: 0x00285938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282583, XrefRangeEnd = 282584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButton2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr_OnButton2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x0028776C File Offset: 0x0028596C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282584, XrefRangeEnd = 282587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x0004F141 File Offset: 0x0004D341
		public CharacterCreatorToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0600A0C9 RID: 41161 RVA: 0x002877A8 File Offset: 0x002859A8
		// (set) Token: 0x0600A0CA RID: 41162 RVA: 0x0004F14A File Offset: 0x0004D34A
		public unsafe Button Button1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0600A0CB RID: 41163 RVA: 0x002877D8 File Offset: 0x002859D8
		// (set) Token: 0x0600A0CC RID: 41164 RVA: 0x0004F169 File Offset: 0x0004D369
		public unsafe Button Button2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BC2 RID: 27586
		private static readonly IntPtr NativeFieldInfoPtr_Button1;

		// Token: 0x04006BC3 RID: 27587
		private static readonly IntPtr NativeFieldInfoPtr_Button2;

		// Token: 0x04006BC4 RID: 27588
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006BC5 RID: 27589
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006BC6 RID: 27590
		private static readonly IntPtr NativeMethodInfoPtr_OnButton1_Public_Void_0;

		// Token: 0x04006BC7 RID: 27591
		private static readonly IntPtr NativeMethodInfoPtr_OnButton2_Public_Void_0;

		// Token: 0x04006BC8 RID: 27592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
