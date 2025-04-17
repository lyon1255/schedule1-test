﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000268 RID: 616
	[Serializable]
	public class MethData : ProductItemData
	{
		// Token: 0x06002F36 RID: 12086 RVA: 0x00018F86 File Offset: 0x00017186
		// Note: this type is marked as 'beforefieldinit'.
		static MethData()
		{
			Il2CppClassPointerStore<MethData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MethData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethData>.NativeClassPtr);
			MethData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethData>.NativeClassPtr, 100668763);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00106FCC File Offset: 0x001051CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130598, RefRangeEnd = 130602, XrefRangeStart = 130598, XrefRangeEnd = 130602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00018FBF File Offset: 0x000171BF
		public MethData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}
