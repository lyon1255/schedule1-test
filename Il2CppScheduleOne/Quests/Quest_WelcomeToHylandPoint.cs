using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C7 RID: 455
	public class Quest_WelcomeToHylandPoint : Quest
	{
		// Token: 0x060026D7 RID: 9943 RVA: 0x000EA548 File Offset: 0x000E8748
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_WelcomeToHylandPoint()
		{
			Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_WelcomeToHylandPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr);
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ReturnToRVQuest");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ReadMessagesQuest");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "RV");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "Nelson");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ExplosionMaxDist");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ExplosionMinDist");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_onExplode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "onExplode");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_exploded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "exploded");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "cameraLookTime");
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667639);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667640);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Explode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667641);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667642);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667643);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667644);
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x000EA6A4 File Offset: 0x000E88A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117539, XrefRangeEnd = 117541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x000EA6E0 File Offset: 0x000E88E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117541, XrefRangeEnd = 117553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x000EA714 File Offset: 0x000E8914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117553, XrefRangeEnd = 117565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Explode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Explode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x000EA748 File Offset: 0x000E8948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117565, XrefRangeEnd = 117583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x000EA7A0 File Offset: 0x000E89A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117583, XrefRangeEnd = 117587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_WelcomeToHylandPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x000EA7DC File Offset: 0x000E89DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117587, XrefRangeEnd = 117591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00015814 File Offset: 0x00013A14
		public Quest_WelcomeToHylandPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x000EA810 File Offset: 0x000E8A10
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x0001581D File Offset: 0x00013A1D
		public unsafe QuestEntry ReturnToRVQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000EA840 File Offset: 0x000E8A40
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x0001583C File Offset: 0x00013A3C
		public unsafe QuestEntry ReadMessagesQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000EA870 File Offset: 0x000E8A70
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x0001585B File Offset: 0x00013A5B
		public unsafe RV RV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000EA8A0 File Offset: 0x000E8AA0
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x0001587A File Offset: 0x00013A7A
		public unsafe UncleNelson Nelson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UncleNelson>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x000EA8D0 File Offset: 0x000E8AD0
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x00015899 File Offset: 0x00013A99
		public unsafe float ExplosionMaxDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist)) = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x000EA8F8 File Offset: 0x000E8AF8
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x000158B4 File Offset: 0x00013AB4
		public unsafe float ExplosionMinDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist)) = value;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x000EA920 File Offset: 0x000E8B20
		// (set) Token: 0x060026EC RID: 9964 RVA: 0x000158CF File Offset: 0x00013ACF
		public unsafe UnityEvent onExplode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_onExplode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_onExplode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x000EA950 File Offset: 0x000E8B50
		// (set) Token: 0x060026EE RID: 9966 RVA: 0x000158EE File Offset: 0x00013AEE
		public unsafe bool exploded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_exploded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_exploded)) = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x000EA978 File Offset: 0x000E8B78
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x00015909 File Offset: 0x00013B09
		public unsafe float cameraLookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime)) = value;
			}
		}

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeFieldInfoPtr_ReturnToRVQuest;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeFieldInfoPtr_ReadMessagesQuest;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeFieldInfoPtr_RV;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_Nelson;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionMaxDist;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionMinDist;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeFieldInfoPtr_onExplode;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeFieldInfoPtr_exploded;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeFieldInfoPtr_cameraLookTime;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_Explode_Public_Void_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0;

		// Token: 0x020008D4 RID: 2260
		[ObfuscatedName("ScheduleOne.Quests.Quest_WelcomeToHylandPoint+<<Explode>g__Shake|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
		{
			// Token: 0x0600C429 RID: 50217 RVA: 0x002FCB50 File Offset: 0x002FAD50
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "<<Explode>g__Shake|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667645);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667646);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667647);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667648);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667649);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667650);
			}

			// Token: 0x0600C42A RID: 50218 RVA: 0x002FCC1C File Offset: 0x002FAE1C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C42B RID: 50219 RVA: 0x002FCC64 File Offset: 0x002FAE64
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C42C RID: 50220 RVA: 0x002FCC98 File Offset: 0x002FAE98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117528, XrefRangeEnd = 117534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D3C RID: 15676
			// (get) Token: 0x0600C42D RID: 50221 RVA: 0x002FCCD4 File Offset: 0x002FAED4
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C42E RID: 50222 RVA: 0x002FCD14 File Offset: 0x002FAF14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117534, XrefRangeEnd = 117539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D3D RID: 15677
			// (get) Token: 0x0600C42F RID: 50223 RVA: 0x002FCD48 File Offset: 0x002FAF48
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C430 RID: 50224 RVA: 0x0005F786 File Offset: 0x0005D986
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D3A RID: 15674
			// (get) Token: 0x0600C431 RID: 50225 RVA: 0x002FCD88 File Offset: 0x002FAF88
			// (set) Token: 0x0600C432 RID: 50226 RVA: 0x0005F78F File Offset: 0x0005D98F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D3B RID: 15675
			// (get) Token: 0x0600C433 RID: 50227 RVA: 0x002FCDB0 File Offset: 0x002FAFB0
			// (set) Token: 0x0600C434 RID: 50228 RVA: 0x0005F7AA File Offset: 0x0005D9AA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084F1 RID: 34033
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040084F2 RID: 34034
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040084F3 RID: 34035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040084F4 RID: 34036
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084F5 RID: 34037
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040084F6 RID: 34038
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040084F7 RID: 34039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084F8 RID: 34040
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
