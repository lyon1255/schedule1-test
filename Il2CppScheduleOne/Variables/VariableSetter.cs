using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000185 RID: 389
	[Serializable]
	public class VariableSetter : Object
	{
		// Token: 0x06001F14 RID: 7956 RVA: 0x000D1880 File Offset: 0x000CFA80
		// Note: this type is marked as 'beforefieldinit'.
		static VariableSetter()
		{
			Il2CppClassPointerStore<VariableSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "VariableSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr);
			VariableSetter.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, "VariableName");
			VariableSetter.NativeFieldInfoPtr_NewValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, "NewValue");
			VariableSetter.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, 100666814);
			VariableSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, 100666815);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000D1900 File Offset: 0x000CFB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108051, RefRangeEnd = 108052, XrefRangeStart = 108046, XrefRangeEnd = 108051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableSetter.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000D1934 File Offset: 0x000CFB34
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x0001174B File Offset: 0x0000F94B
		public VariableSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x000D1970 File Offset: 0x000CFB70
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00011754 File Offset: 0x0000F954
		public unsafe string VariableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_VariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x000D1998 File Offset: 0x000CFB98
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00011773 File Offset: 0x0000F973
		public unsafe string NewValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_NewValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_NewValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeFieldInfoPtr_VariableName;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeFieldInfoPtr_NewValue;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
