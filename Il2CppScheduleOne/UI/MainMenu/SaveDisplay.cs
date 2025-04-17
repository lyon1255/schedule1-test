using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006EB RID: 1771
	public class SaveDisplay : MonoBehaviour
	{
		// Token: 0x06009E80 RID: 40576 RVA: 0x00280908 File Offset: 0x0027EB08
		// Note: this type is marked as 'beforefieldinit'.
		static SaveDisplay()
		{
			Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SaveDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr);
			SaveDisplay.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, "Slots");
			SaveDisplay.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682743);
			SaveDisplay.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682744);
			SaveDisplay.NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682745);
			SaveDisplay.NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682746);
			SaveDisplay.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682747);
			SaveDisplay.NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682748);
			SaveDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682749);
		}

		// Token: 0x06009E81 RID: 40577 RVA: 0x002809D8 File Offset: 0x0027EBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280098, XrefRangeEnd = 280117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E82 RID: 40578 RVA: 0x00280A0C File Offset: 0x0027EC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280117, XrefRangeEnd = 280125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x00280A40 File Offset: 0x0027EC40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280196, RefRangeEnd = 280198, XrefRangeStart = 280125, XrefRangeEnd = 280196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedSave(int index, SaveInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x00280A90 File Offset: 0x0027EC90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280204, RefRangeEnd = 280206, XrefRangeStart = 280198, XrefRangeEnd = 280204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RoundToDecimalPlaces(float value, int decimalPlaces)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPlaces;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x00280AE8 File Offset: 0x0027ECE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280206, RefRangeEnd = 280208, XrefRangeStart = 280206, XrefRangeEnd = 280206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x00280B28 File Offset: 0x0027ED28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280215, RefRangeEnd = 280217, XrefRangeStart = 280208, XrefRangeEnd = 280215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTimeLabel(int hours)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hours;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x00280B6C File Offset: 0x0027ED6C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x0004DBE9 File Offset: 0x0004BDE9
		public SaveDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x06009E89 RID: 40585 RVA: 0x00280BA8 File Offset: 0x0027EDA8
		// (set) Token: 0x06009E8A RID: 40586 RVA: 0x0004DBF2 File Offset: 0x0004BDF2
		public unsafe Il2CppReferenceArray<RectTransform> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDisplay.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDisplay.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A5F RID: 27231
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04006A60 RID: 27232
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006A61 RID: 27233
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04006A62 RID: 27234
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0;

		// Token: 0x04006A63 RID: 27235
		private static readonly IntPtr NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0;

		// Token: 0x04006A64 RID: 27236
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0;

		// Token: 0x04006A65 RID: 27237
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0;

		// Token: 0x04006A66 RID: 27238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
