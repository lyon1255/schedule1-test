using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000267 RID: 615
	public class MessagesData : SaveData
	{
		// Token: 0x06002F33 RID: 12083 RVA: 0x00018F44 File Offset: 0x00017144
		// Note: this type is marked as 'beforefieldinit'.
		static MessagesData()
		{
			Il2CppClassPointerStore<MessagesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MessagesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesData>.NativeClassPtr);
			MessagesData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesData>.NativeClassPtr, 100668762);
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00106F90 File Offset: 0x00105190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130409, RefRangeEnd = 130410, XrefRangeStart = 130409, XrefRangeEnd = 130410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00018F7D File Offset: 0x0001717D
		public MessagesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
