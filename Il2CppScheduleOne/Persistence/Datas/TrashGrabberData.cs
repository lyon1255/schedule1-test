using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026C RID: 620
	[Serializable]
	public class TrashGrabberData : ItemData
	{
		// Token: 0x06002F4C RID: 12108 RVA: 0x00107394 File Offset: 0x00105594
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberData()
		{
			Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashGrabberData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr);
			TrashGrabberData.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr, "Content");
			TrashGrabberData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr, 100668767);
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x001073EC File Offset: 0x001055EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130436, RefRangeEnd = 130442, XrefRangeStart = 130436, XrefRangeEnd = 130442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberData(string iD, int quantity, TrashContentData content) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x00019072 File Offset: 0x00017272
		public TrashGrabberData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x00107458 File Offset: 0x00105658
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x0001907B File Offset: 0x0001727B
		public unsafe TrashContentData Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberData.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberData.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrashContentData_0;
	}
}
