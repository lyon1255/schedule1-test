using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x020004B0 RID: 1200
	[Serializable]
	public class StringDatabase : ScriptableObject
	{
		// Token: 0x060069B1 RID: 27057 RVA: 0x001D8FF0 File Offset: 0x001D71F0
		// Note: this type is marked as 'beforefieldinit'.
		static StringDatabase()
		{
			Il2CppClassPointerStore<StringDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "StringDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr);
			StringDatabase.NativeFieldInfoPtr_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr, "Strings");
			StringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr, 100676718);
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x001D9048 File Offset: 0x001D7248
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x00031F56 File Offset: 0x00030156
		public StringDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x060069B4 RID: 27060 RVA: 0x001D9084 File Offset: 0x001D7284
		// (set) Token: 0x060069B5 RID: 27061 RVA: 0x00031F5F File Offset: 0x0003015F
		public unsafe Il2CppStringArray Strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDatabase.NativeFieldInfoPtr_Strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDatabase.NativeFieldInfoPtr_Strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004865 RID: 18533
		private static readonly IntPtr NativeFieldInfoPtr_Strings;

		// Token: 0x04004866 RID: 18534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
