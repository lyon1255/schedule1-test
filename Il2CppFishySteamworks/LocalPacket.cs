using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFishySteamworks
{
	// Token: 0x0200078D RID: 1933
	public sealed class LocalPacket : ValueType
	{
		// Token: 0x0600B715 RID: 46869 RVA: 0x002D7350 File Offset: 0x002D5550
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPacket()
		{
			Il2CppClassPointerStore<LocalPacket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "LocalPacket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr);
			LocalPacket.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, "Data");
			LocalPacket.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, "Length");
			LocalPacket.NativeFieldInfoPtr_Channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, "Channel");
			LocalPacket.NativeMethodInfoPtr__ctor_Public_Void_ArraySegment_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, 100685789);
		}

		// Token: 0x0600B716 RID: 46870 RVA: 0x002D73D0 File Offset: 0x002D55D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311719, XrefRangeEnd = 311731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPacket(ArraySegment<byte> data, byte channel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPacket.NativeMethodInfoPtr__ctor_Public_Void_ArraySegment_1_Byte_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B717 RID: 46871 RVA: 0x00059EE0 File Offset: 0x000580E0
		public LocalPacket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x00059EE9 File Offset: 0x000580E9
		public LocalPacket() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr))
		{
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600B719 RID: 46873 RVA: 0x002D7434 File Offset: 0x002D5634
		// (set) Token: 0x0600B71A RID: 46874 RVA: 0x00059EFB File Offset: 0x000580FB
		public unsafe Il2CppStructArray<byte> Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600B71B RID: 46875 RVA: 0x002D7464 File Offset: 0x002D5664
		// (set) Token: 0x0600B71C RID: 46876 RVA: 0x00059F1A File Offset: 0x0005811A
		public unsafe int Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Length)) = value;
			}
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0600B71D RID: 46877 RVA: 0x002D748C File Offset: 0x002D568C
		// (set) Token: 0x0600B71E RID: 46878 RVA: 0x00059F35 File Offset: 0x00058135
		public unsafe byte Channel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Channel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Channel)) = value;
			}
		}

		// Token: 0x04007B4E RID: 31566
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x04007B4F RID: 31567
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x04007B50 RID: 31568
		private static readonly IntPtr NativeFieldInfoPtr_Channel;

		// Token: 0x04007B51 RID: 31569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArraySegment_1_Byte_Byte_0;
	}
}
