using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200036E RID: 878
	public class NetworkConditionalObject : MonoBehaviour
	{
		// Token: 0x060044AD RID: 17581 RVA: 0x0015309C File Offset: 0x0015129C
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkConditionalObject()
		{
			Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "NetworkConditionalObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr);
			NetworkConditionalObject.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, "condition");
			NetworkConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100671685);
			NetworkConditionalObject.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100671686);
			NetworkConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100671687);
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x0015311C File Offset: 0x0015131C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155398, XrefRangeEnd = 155433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x00153150 File Offset: 0x00151350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155433, XrefRangeEnd = 155436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x00153184 File Offset: 0x00151384
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkConditionalObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x00021884 File Offset: 0x0001FA84
		public NetworkConditionalObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060044B2 RID: 17586 RVA: 0x001531C0 File Offset: 0x001513C0
		// (set) Token: 0x060044B3 RID: 17587 RVA: 0x0002188D File Offset: 0x0001FA8D
		public unsafe NetworkConditionalObject.ECondition condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkConditionalObject.NativeFieldInfoPtr_condition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkConditionalObject.NativeFieldInfoPtr_condition)) = value;
			}
		}

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeFieldInfoPtr_condition;

		// Token: 0x04002E01 RID: 11777
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002E02 RID: 11778
		private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;

		// Token: 0x04002E03 RID: 11779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000968 RID: 2408
		[OriginalName("Assembly-CSharp.dll", "", "ECondition")]
		public enum ECondition
		{
			// Token: 0x0400883E RID: 34878
			All,
			// Token: 0x0400883F RID: 34879
			HostOnly
		}
	}
}
