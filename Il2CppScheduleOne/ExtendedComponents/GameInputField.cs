using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.ExtendedComponents
{
	// Token: 0x020003FB RID: 1019
	public class GameInputField : TMP_InputField
	{
		// Token: 0x060054EC RID: 21740 RVA: 0x0018D3FC File Offset: 0x0018B5FC
		// Note: this type is marked as 'beforefieldinit'.
		static GameInputField()
		{
			Il2CppClassPointerStore<GameInputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ExtendedComponents", "GameInputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInputField>.NativeClassPtr);
			GameInputField.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100673851);
			GameInputField.NativeMethodInfoPtr_EditStart_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100673852);
			GameInputField.NativeMethodInfoPtr_EndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100673853);
			GameInputField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100673854);
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x0018D47C File Offset: 0x0018B67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180269, XrefRangeEnd = 180287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInputField.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x0018D4B8 File Offset: 0x0018B6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180287, XrefRangeEnd = 180291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditStart(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInputField.NativeMethodInfoPtr_EditStart_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x0018D4FC File Offset: 0x0018B6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180291, XrefRangeEnd = 180295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEdit(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInputField.NativeMethodInfoPtr_EndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x0018D540 File Offset: 0x0018B740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180295, XrefRangeEnd = 180299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameInputField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInputField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x00028C4D File Offset: 0x00026E4D
		public GameInputField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003978 RID: 14712
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003979 RID: 14713
		private static readonly IntPtr NativeMethodInfoPtr_EditStart_Private_Void_String_0;

		// Token: 0x0400397A RID: 14714
		private static readonly IntPtr NativeMethodInfoPtr_EndEdit_Private_Void_String_0;

		// Token: 0x0400397B RID: 14715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
