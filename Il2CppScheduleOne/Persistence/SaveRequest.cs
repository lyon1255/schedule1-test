using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x02000222 RID: 546
	public class SaveRequest : Object
	{
		// Token: 0x06002DA0 RID: 11680 RVA: 0x001016E0 File Offset: 0x000FF8E0
		// Note: this type is marked as 'beforefieldinit'.
		static SaveRequest()
		{
			Il2CppClassPointerStore<SaveRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SaveRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr);
			SaveRequest.NativeFieldInfoPtr_Saveable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "Saveable");
			SaveRequest.NativeFieldInfoPtr_ParentFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "ParentFolderPath");
			SaveRequest.NativeFieldInfoPtr__SaveString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "<SaveString>k__BackingField");
			SaveRequest.NativeMethodInfoPtr_get_SaveString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668522);
			SaveRequest.NativeMethodInfoPtr_set_SaveString_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668523);
			SaveRequest.NativeMethodInfoPtr__ctor_Public_Void_ISaveable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668524);
			SaveRequest.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668525);
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x0010179C File Offset: 0x000FF99C
		// (set) Token: 0x06002DA2 RID: 11682 RVA: 0x001017D4 File Offset: 0x000FF9D4
		public unsafe string SaveString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_get_SaveString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_set_SaveString_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00101818 File Offset: 0x000FFA18
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 127137, RefRangeEnd = 127156, XrefRangeStart = 127114, XrefRangeEnd = 127137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest(ISaveable saveable, string parentFolderPath) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr__ctor_Public_Void_ISaveable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00101878 File Offset: 0x000FFA78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127168, RefRangeEnd = 127169, XrefRangeStart = 127156, XrefRangeEnd = 127168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000187AE File Offset: 0x000169AE
		public SaveRequest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x001018AC File Offset: 0x000FFAAC
		// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x000187B7 File Offset: 0x000169B7
		public unsafe ISaveable Saveable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_Saveable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISaveable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_Saveable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x001018DC File Offset: 0x000FFADC
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x000187D6 File Offset: 0x000169D6
		public unsafe string ParentFolderPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_ParentFolderPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_ParentFolderPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x00101904 File Offset: 0x000FFB04
		// (set) Token: 0x06002DAB RID: 11691 RVA: 0x000187F5 File Offset: 0x000169F5
		public unsafe string _SaveString_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__SaveString_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__SaveString_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeFieldInfoPtr_Saveable;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeFieldInfoPtr_ParentFolderPath;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeFieldInfoPtr__SaveString_k__BackingField;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveString_Public_get_String_0;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeMethodInfoPtr_set_SaveString_Private_set_Void_String_0;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISaveable_String_0;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;
	}
}
